using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using MovieStoreWebApi.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MovieStoreWebApi.TokenOperations.Models;

namespace MovieStoreWebApi.TokenOperations
{
    public class TokenHandler
    {
        public IConfiguration Configuration{get;set;}
        public TokenHandler (IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public Token CreateAccessToken(User user)
        {
            Token tokenModel = new Token();
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"]));

            SigningCredentials signingCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            
            tokenModel.Expiration = DateTime.Now.AddMinutes(15);
            JwtSecurityToken securityToken = new JwtSecurityToken(
                issuer:Configuration["Token:Issuer"],
                audience:Configuration["Token:Audiece"],
                expires:tokenModel.Expiration,
                notBefore:DateTime.Now,
                signingCredentials: signingCredentials
            );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            tokenModel.AccessToken = tokenHandler.WriteToken(securityToken);
            tokenModel.RefreshToken = CreateRefreshToken();

            return tokenModel;

        }
        public string CreateRefreshToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
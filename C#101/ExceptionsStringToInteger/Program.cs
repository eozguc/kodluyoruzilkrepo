using System;

namespace ExceptionsStringToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            try
            {
                int num = int.Parse(str);
                Console.WriteLine(num);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
    
}

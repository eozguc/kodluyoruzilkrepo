using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace WordTotalAmount
{
    
       /*
       [] Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
       [] Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
       */


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cumle yaziniz...");
            string input = Console.ReadLine();

            string[] splittedSentence = input.Split(" ");

            int wordAmount = splittedSentence.Length;
            int letterAmount = string.Join("", splittedSentence).Length;

            System.Console.WriteLine($"Cümledeki toplam kelime  : {wordAmount}\nToplam harf sayısı : {letterAmount}(Boşluk olmadan)");
        }
    }
}
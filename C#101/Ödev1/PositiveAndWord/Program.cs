using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace PositiveAndWord
{
    
    /*
    [*] Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
    [*] Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
    [*] Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
    */


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif sayi girin");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter {input} adet kelime giriniz");
            string[] words1 = new string[input];
            for (int i = 0; i < input; i++)
            {
                words1[i] = Console.ReadLine();
            }

            Array.Reverse(words1);

            foreach (var word1 in words1)
                Console.WriteLine(word1);
        }
    }
}
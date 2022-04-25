using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace PositiveTwoNumber
{
    class Program
    {
        /*
       [*] Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
       [*] Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
       [*] Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
       */
        public static void Main(string[] args)
        {
         
            Console.WriteLine("Pozitif iki tam sayi giriniz");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please enter {input1} adet pozitif sayi giriniz)");
            int[] nums1 = new int[input1];
            for (int i = 0; i < input1; i++)
            {
                nums1[i] = int.Parse(Console.ReadLine());
            }

            foreach (var num1 in PositiveNumbers(input2, nums1))
                Console.WriteLine(num1);
        }

        public static int[] PositiveNumbers(int inputInteger, int[] inputArray)
        {
            inputArray = inputArray.Where(x => x % inputInteger == 0).ToArray();
            return inputArray;
        }
    }
}
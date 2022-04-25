using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace PositiveNumber
{
    class Program
    {
        /*
        [*] Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
        [*] Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        [*] Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        */
        public static void Main(string[] args)
        {
         
            Console.WriteLine("Hello please enter a positive integer");
            int positiveNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter {positiveNumber} amount positive integer(press Enter after each integer to submit)");
            int[] nums1 = new int[positiveNumber];
            for (int i = 0; i < positiveNumber; i++)
            {
                nums1[i] = int.Parse(Console.ReadLine());
            }
            
            foreach (var num1 in nums1.EvenNumber())
                Console.WriteLine(num1);
            
           
        }

        public static int[] EvenNumber(int[] input)
        {
            input = input.Where(x => x % 2 == 0).ToArray();
            return input;
        }
    }
}
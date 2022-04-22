using System;

namespace Day_3_TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Başka bir sayı giriniz.");
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1,val2);
            Console.WriteLine("Toplam: " + sum);
        }
        static int solveMeFirst(int a, int b)
        { 
            
            return a+b;
        }
    }
}
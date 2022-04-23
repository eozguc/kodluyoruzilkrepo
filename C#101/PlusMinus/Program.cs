using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));


            plusMinus(arr);
        }


        static void plusMinus(int[] arr)
        {
            double positives = 0;
            double negatives = 0;
            double zeros = 0;
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    positives++;
                }
                else if (num < 0)
                {
                    negatives++;
                }
                else
                {
                    zeros++;
                }
            }

            Console.WriteLine(positives / Convert.ToInt32(arr.Length));
            Console.WriteLine(negatives / Convert.ToInt32(arr.Length));
            Console.WriteLine(zeros / Convert.ToInt32(arr.Length));






        }
    }
}

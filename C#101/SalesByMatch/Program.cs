﻿using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        public static int sockMerchant(int n, List<int> ar)
        {
            int[] arr = new int[ar.Max()];
            for(int i=0; i<ar.Count; i++)
            {
                arr[ar[i]-1]++;
            }
        
            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                while(arr[i]>1)
                {
                    count++;
                    arr[i] = arr[i] - 2;    
                }
            }
            return count;
        }
    }
}
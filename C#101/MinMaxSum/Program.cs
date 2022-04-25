using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace MinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            miniMaxSum(arr);
        }
        
        public static void miniMaxSum(List<int> arr)
        {
            long min = 0, max = 0;
            arr.Sort();
            for(int i=0; i<arr.Count; i++)
            {
                if(i!=0) max += arr[i];
                if(i!=arr.Count-1) min += arr[i];   
            }
            Console.WriteLine(min + " " +max);
        }
    }
}
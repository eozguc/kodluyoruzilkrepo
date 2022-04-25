using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = divisibleSumPairs(n, k, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            for(int i=0; i<ar.Count-1; i++)
            {
                for(int j=i+1; j<ar.Count; j++)
                {
                    if((ar[i] + ar[j])%k==0) count++;
                }
            }
            return count;
        }
    }
}
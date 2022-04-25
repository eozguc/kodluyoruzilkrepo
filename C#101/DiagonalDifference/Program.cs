using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        
        public static int diagonalDifference(List<List<int>> arr)
        {
            int a=0, b=0;
            for(int i=0; i<arr.Count; i++)
            {
                a += arr[i][i];
                b += arr[i][arr.Count-1-i];
            }
            
            if(a-b>0)
            {
                return a-b;
            } 
            else
            {
                return (a-b) * -1;    
            } 
        }
    }
}
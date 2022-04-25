using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace SubarrayDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = birthday(s, d, m);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        public static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
        
            for(int i=0; i<s.Count; i++)
            {
                int tmp = 0;
                for(int j=i; j<i+m; j++)
                {
                    if(j==s.Count) break;
                    tmp += s[j];
                }
                if(d==tmp) count++;
            }
            return count;
        }
    }
}
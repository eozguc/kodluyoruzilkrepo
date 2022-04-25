using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace NumberLineJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = kangaroo(x1, v1, x2, v2);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            //x1 is first kangaroo point, v1 is first kangaroo jump length
            //x2 is first kangaroo point, v2 is first kangaroo jump length
        
            int firstKangaroo = x1;
            int secondKangaroo = x2;
            
            if(v2>v1) return "NO";
            while(firstKangaroo<secondKangaroo)
            {
                firstKangaroo += v1;
                secondKangaroo += v2;
                
                if(firstKangaroo==secondKangaroo) return "YES";
            }
            
            return "NO";
        }
    }
}
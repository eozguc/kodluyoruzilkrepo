using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = countingValleys(steps, path);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        
        public static int countingValleys(int steps, string path)
        {
            int count = 0;
            int level = 0;
        
            for(int i=0; i<steps; i++)
            {
                if(path[i]=='D' && level==0)
                {
                    count++;
                    level--;
                    continue;
                }
                if(path[i]=='D') level--;
                else if(path[i]=='U') level++;
            }
            return count;
        }

    }
}
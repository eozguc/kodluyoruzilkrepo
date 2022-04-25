using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = breakingRecords(scores);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
        public static List<int> breakingRecords(List<int> scores)
        {
            int low = scores[0];
            int high = scores[0];
            int lowCount = 0;
            int highCount = 0;
            
            for(int i=1; i<scores.Count; i++)
            {
                if(high<scores[i]) { highCount++; high = scores[i]; }
                if(low>scores[i]) { lowCount++; low = scores[i]; }
            }
            List<int> result = new List<int>();
            result.Add(highCount);
            result.Add(lowCount);
        
            return result;
        }
    }
}
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int count = 0;
            for(int i=0; i<candles.Count; i++)
            {
                if(candles[i]==max) count++;
            }
        
            return count;
        }
    }
}
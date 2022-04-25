using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace BirthdayCake
{
    class Program
    {
        static void Main(string[] args)
        {
	        int arCount = Convert.ToInt32(Console.ReadLine());

	        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

	        int result = birthdayCakeCandles(ar);

	        Console.WriteLine(result);
        
        
	        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

	        //int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

	        // List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

	        // int result = Result.birthdayCakeCandles(candles);

	        // textWriter.WriteLine(result);

	        // textWriter.Flush();
	        //  textWriter.Close();
		
		
        }
	
        public static int birthdayCakeCandles(int[] candles)
        {
	        int max = candles.Max();

	        return candles.Count(x => x == max);
        }
    }
}
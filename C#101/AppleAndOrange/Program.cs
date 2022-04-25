using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
        
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0;
            int orangesCount = 0;
            for(int i=0; i<apples.Count; i++)
            {
                if(a + apples[i] >= s && a + apples[i] <= t ) applesCount++;
            }
            for(int i=0; i<oranges.Count; i++)
            {
                if(b + oranges[i] >= s && b + oranges[i] <= t ) orangesCount++;
            }
            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }
    }
}
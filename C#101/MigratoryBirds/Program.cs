using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        public static int migratoryBirds(List<int> arr)
        {
            int[] count = new int[arr.Max()];
            int max = 0, c = 0;
            
            for(int i=0; i<arr.Count; i++)
            {
                count[arr[i]-1]++;
            }
            
            for(int i=0; i<count.Length; i++)
            {
                if(max<count[i]) {max = count[i]; c = i; }
            }
            return c + 1;
        }
        
        
        //static void Main(String[] args)
       // {
            //No need to capture the size of array. I use array's length property instead.
       //     ReadLine();
        //    var ar_temp = ReadLine().Split(' ');
       //     var ar = Array.ConvertAll(ar_temp, int.Parse);
       //     var result = MigratoryBirds(ar);
       //     WriteLine(result);
      //  }

       // static int MigratoryBirds(int[] ar)
     //   {
      //      var birdTypeCounts = new int[5];

       //     for (int i = 0; i < ar.Length; i++)
       //         birdTypeCounts[ar[i] - 1]++;

       //     var maxBirdTypeCount = birdTypeCounts[0];
        //    var maxBirdType = 1;

        //    for (int i = 1; i < 5; i++)
        //    {
        //        if (birdTypeCounts[i] > maxBirdTypeCount)
       //         {
         //           maxBirdTypeCount = birdTypeCounts[i];
         //           maxBirdType = i + 1;
          //      }

           //     if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
           //         maxBirdType = i + 1;
           // }

          //  return maxBirdType;
       // }
    }
}
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp))
                .ToList();

            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);


            textWriter.Flush();
            textWriter.Close();
        }

       public static int simpleArraySum(List<int> ar)
        {

            int sum = 0;
            foreach (var number in ar)
            {
                sum = sum + number;
            }

            return sum;
        }
    }
}
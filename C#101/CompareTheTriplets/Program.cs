using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
        
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aliceScor=0;
            int bobScor=0;
            for(int i=0;i<a.Count;i++)
            {
                if(a[i]>b[i])
                {
                    aliceScor=aliceScor+1;
                }
                else if(a[i]<b[i])
                {
                    bobScor=bobScor+1;
                }
           
            }
            List<int> scor=new List<int>();
            scor.Add(aliceScor);
            scor.Add(bobScor);
            return scor;
        }
    }
}
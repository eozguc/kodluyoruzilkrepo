using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int result = pageCount(n, p);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        
        public static int pageCount(int n, int p)
        {
            int count = 0;
            
            if(n%2==0) n++;
            if(p%2==0) p++;
            if(n-p>p)
            {
                int tmp=1;
                while(tmp<p)
                {
                    count++;
                    tmp+=2;
                }
            }
            else
            {
                while(n>p)
                {
                    count++;
                    n -=2;
                }    
            }
        
            return count; 
        }
    }
}
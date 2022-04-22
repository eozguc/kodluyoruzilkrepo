using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
        
            if(N %2==1 ||(N>=6&& N<=20))
            {
                Console.Write("Weird");
            }
            else

            {
                Console.Write("Not Weird");
            }
        }
    }
}
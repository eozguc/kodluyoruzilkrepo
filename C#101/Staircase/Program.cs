
using System.Text;
using System;


namespace Staircase
{
    public class Program
    {
        /*
      * Complete the 'staircase' function below.
      *
      * The function accepts INTEGER n as parameter.
      */

        // Complete the staircase function below.
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                StringBuilder step = new StringBuilder(String.Empty);

                step.Append(' ', n - i);
                step.Append('#', i);

                Console.WriteLine(step);
            }
        }

    }

    public class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Program.staircase(n);
        }
    }
}
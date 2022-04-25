using System;

namespace Let_sReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            for (var i = 0; i < N; i++)
            {
                var str = Console.ReadLine();

                for (var j = 0; j < str.Length; j++)
                {
                    if (j % 2 == 0) Console.Write(str[j]);
                }

                Console.Write(" ");

                for (var j = 0; j < str.Length; j++)
                {
                    if (j % 2 != 0) Console.Write(str[j]);
                }

                Console.Write(Environment.NewLine);
            }
        }
    }
}

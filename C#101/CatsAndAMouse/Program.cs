using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CatsAndAMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++) {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
        
        static string catAndMouse(int x, int y, int z) 
        {
            int zx=0, zy=0;
            if(z-x<0) zx = (z-x) * -1;
            else zx = z-x;
            if(z-y<0) zy = (z-y) * -1;
            else zy = z-y;
            if(zx==zy) return "Mouse C";
            if(zx<zy) return "Cat A";
            else return "Cat B";
        }
    }
}
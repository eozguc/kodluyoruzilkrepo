﻿using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
                ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
                ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            textWriter.WriteLine(moneySpent);

            textWriter.Flush();
            textWriter.Close();
        }
        
        static int getMoneySpent(int[] keyboards, int[] drives, int b) 
        {
            int maxCost=-1;
        
            for(int i=0; i<keyboards.Length; i++)
            {
                for(int j=0; j<drives.Length; j++)
                {
                    if(keyboards[i]+drives[j]<=b && keyboards[i]+drives[j] > maxCost) 
                    {
                        maxCost=keyboards[i]+drives[j];
                    }
                }
            }        
            return maxCost;
        }
    }
}
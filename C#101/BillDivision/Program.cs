using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace BillDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int annaPay = 0;
        
            for(int i=0; i<bill.Count; i++)
            {
                if(i != k)
                {
                    annaPay += bill[i];
                }
            }
            annaPay = b-annaPay/2;
            if(annaPay==0) Console.WriteLine("Bon Appetit");
            else Console.WriteLine(annaPay);
        }
    }
    
}
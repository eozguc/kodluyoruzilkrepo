using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
        
            int n = Convert.ToInt32(Console.ReadLine().Trim());
        
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);

            for (var i = n - 1; i > -1; i--)
            {
                Console.Write(arr[i] + " ");
            }
            
            
            
            
            
            
            
            
            
            // int n = Convert.ToInt32(Console.ReadLine().Trim());

            // List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
            //int n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
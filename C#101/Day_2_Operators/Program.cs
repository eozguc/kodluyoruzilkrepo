using System;

namespace Day_2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yemek bedeli giriniz");
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());
            Console.WriteLine("Bahşiş bedeli giriniz");
            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Vergi bedeli giriniz");
            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            solve(meal_cost, tip_percent, tax_percent);

            Console.ReadKey();
        }
        private static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            //HackerRank Sitesindeki 30 Days Challenge Day 2 Ödevi
            double tipPercent = Convert.ToDouble(tip_percent);
            double taxPercent = Convert.ToDouble(tax_percent);
        
            double tip = (tipPercent/100)*meal_cost;
            double tax = (taxPercent/100)*meal_cost;
            double total_cost = meal_cost + tip + tax;
        
            int total = Convert.ToInt32(total_cost);
        
            Console.WriteLine(total);

        }
    }
}
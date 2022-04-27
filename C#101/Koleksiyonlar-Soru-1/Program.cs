using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            ArrayList primeNumberList = new ArrayList();
            ArrayList nonPrimeNumberList = new ArrayList();
            //
            int positiveIntNumber;
            int checkNumber = 0;
            //
            int totalPrimeNumber = 0;
            int totalNonPrimeNumber = 0;


            Console.WriteLine("Asal olan ve olmayan sayıları listelemek için 20 adet sayı girmeniz gerekli.");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Pozitif bir tam sayı giriniz.");
                bool isInt = int.TryParse(Console.ReadLine(), out positiveIntNumber);

                while (!isInt || positiveIntNumber <= 0)
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Pozitif bir tam sayı giriniz.");
                    isInt = int.TryParse(Console.ReadLine(), out positiveIntNumber);
                }
                if (isInt || positiveIntNumber > 0)
                {
                    numbers.Add(positiveIntNumber);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 2; j < (int)numbers[i]; j++)
                {
                    if ((int)numbers[i] % j == 0)
                        checkNumber++;
                }

                if (checkNumber != 0 || (int)numbers[i] == 1)
                    nonPrimeNumberList.Add(numbers[i]);
                else
                    primeNumberList.Add(numbers[i]);

                checkNumber = 0;


            }
            primeNumberList.Sort();
            nonPrimeNumberList.Sort();

            Console.WriteLine("**** Asal Sayılar****");
            foreach (var item in primeNumberList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**** Asal Olmayan Sayılar****");
            foreach (var item in nonPrimeNumberList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Asal sayılar : {0} adetdir.", primeNumberList.Count);
            Console.WriteLine("Asal olmayan sayılar : {0} adetdir.", nonPrimeNumberList.Count);

            foreach (var item in primeNumberList)
            {
                totalPrimeNumber += (int)item;
            }

            foreach (var item in nonPrimeNumberList)
            {
                totalNonPrimeNumber += (int)item;
            }

            Console.WriteLine("Asal sayıların toplamı : {0}", totalPrimeNumber);
            Console.WriteLine("Asal sayıların ortalaması : {0}", (double)totalPrimeNumber / primeNumberList.Count);
            Console.WriteLine("Asal olmayan sayıların toplamı : {0}", totalNonPrimeNumber);
            Console.WriteLine("Asal olmayan sayıların ortalaması : {0}", (double)totalNonPrimeNumber / nonPrimeNumberList.Count);

        }
    }
}

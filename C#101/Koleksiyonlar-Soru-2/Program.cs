using System;

namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[20];
            int number;
            bool isNumber;

            Console.WriteLine("Listeye eklemek için 20 adet sayı girmelisiniz");

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine("Bir tam sayı giriniz");
                isNumber = int.TryParse(Console.ReadLine(), out number);
                while (!isNumber)
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Bir tam sayı giriniz");
                    isNumber = int.TryParse(Console.ReadLine(), out number);
                }
                numberArray[i] = number;
            }

            Array.Sort(numberArray);

            int smallestNumbersSum = numberArray[0] + numberArray[1] + numberArray[2];
            int biggestNumbersSum = numberArray[17] + numberArray[18] + numberArray[19];

            Console.WriteLine("Girdiğiniz en küçük üç sayı : {0}, {1}, {2}", numberArray[0], numberArray[1], numberArray[2]);
            Console.WriteLine("Girdiğiniz en büyük üç sayı : {0}, {1}, {2}", numberArray[17], numberArray[18], numberArray[19]);

            Console.WriteLine($"Girdiğiniz en küçük üç sayının toplamı : {smallestNumbersSum}");
            Console.WriteLine($"Girdiğiniz en büyük üç sayının toplamı : {biggestNumbersSum}");

            Console.WriteLine($"Girdiğiniz en küçük üç sayının ortalaması :{(double)smallestNumbersSum / 3}");
            Console.WriteLine($"Girdiğiniz en büyük üç sayının ortalaması :{(double)biggestNumbersSum / 3}");

            Console.WriteLine($"Girdiğiniz en büyük üç ve en küçük üç sayının ortalamasının toplamları :{((double)smallestNumbersSum / 3) + ((double)biggestNumbersSum / 3)}");

        }
    }
}

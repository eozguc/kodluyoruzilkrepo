using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cumartesi);

            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyelim");
            }
            else if (sicaklik >= (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hadi dışarı çıkalım");
            }
            Console.WriteLine(abc.u);
            Console.ReadKey();

        }
    }

    public static class abc
    {
        private static int x;
        public const double u = 8;
       
    }
    enum Gunler
    {
        pazartesi = 1,
        salı,
        çarşamba,
        periembe,
        cuma = 24,
        cumartesi,
        pazar

    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}


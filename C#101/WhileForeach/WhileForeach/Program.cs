
using System;

namespace WhileForeach;

class Program
{
    static void Main(string[] args)
    {
        // *****while döngü deyimi*****

        // // 1 den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp konsala yazdırıldı.
        // Console.Write("Lütfen bir sayı giriniz: ");
        // int sayi = int.Parse(Console.ReadLine());
        // int sayac = 1;
        // int toplam = 0;
        // while (sayac <= sayi)
        // {
        //     toplam += sayac;
        //     sayac++;
        // }
        // Console.WriteLine(toplam / sayi);            


        // // 'a' dan 'z' ye kadar tüm harfler konsola yazdırıldı.            
        // char character = 'a';
        // while (character < 'z')
        // {
        //     Console.Write(character);
        //     character++;
        // }


        // *****Foreach döngü deyimi*****

        string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }

    }
}
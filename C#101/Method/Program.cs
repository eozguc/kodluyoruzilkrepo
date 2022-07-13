using System;


namespace Method;

class Program
{
    static void Main(string[] args)
    {
        // erişim_belirteci geri_donus_tipi  metot_adi(parametreListesi/arguman)
        // {
        //// komutlar;
        //// return;
        // } 

        int a = 2;
        int b = 3;
        Console.WriteLine(a + b);

        int sonuc = Topla(a, b); // değer tipinde parametre verilir.
        Console.WriteLine(sonuc);

        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc));

        int sonuc2 = ornek.ArttirVeTopla(ref a, ref b); //referans tipinde parametre verilir.
        ornek.EkranaYazdir(Convert.ToString(sonuc2));  //sonuc2=7
        ornek.EkranaYazdir(Convert.ToString(a + b));  //a+b=7 referanslar üzerinde işlem yapıldığından asıl değişken değişir, a=3 b=4 olur.
    }
    static int Topla(int deger1, int deger2)
    {
        return (deger1 + deger2);
    }
}
class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public int ArttirVeTopla(ref int deger1, ref int deger2)
    {
        deger1 += 1;
        deger2 += 1;
        return deger1 + deger2;
    }
}
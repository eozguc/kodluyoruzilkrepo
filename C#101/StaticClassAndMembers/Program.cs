using System;


namespace StaticClassAndMembers;

class Program
{
    static void Main(string[] args)
    {
            
        Console.WriteLine($"çalışan sayısı :{Calisan.CalisanSayisi} ");
        Calisan calisan1 = new Calisan("Ayşe", "Yılmaz", "IK");
        
        Console.WriteLine($"çalışan sayısı :{Calisan.CalisanSayisi} ");
        Calisan calisan2 = new Calisan("Deniz", "Arda", "IK");
        
        Console.WriteLine($"çalışan sayısı :{Calisan.CalisanSayisi} ");
        Calisan calisan3 = new Calisan("Zikriye", "Ürkmez", "IK");
      
        Console.WriteLine($"çalışan sayısı :{Calisan.CalisanSayisi} ");
        Console.WriteLine("-------------------");
        Console.WriteLine("Toplama İşlemi Sonucu :{0}",Islem.Topla(100, 200));
        Console.WriteLine("Çıkarma İşlemi Sonucu :{0}",Islem.Cikar(400, 50));

        Console.ReadKey();

    }
}

class Calisan
{
    private static int calisanSayisi;
    private string Isim;
    private string SoyIsim;
    private string Departman;

    static Calisan()
    {
        calisanSayisi = 0;
    }
    public Calisan(string isim, string soyIsim, string departman)
    {
        this.Isim = isim;
        this.SoyIsim = soyIsim;
        this.Departman = departman;
        calisanSayisi++;
    }

    public static int CalisanSayisi
    {
        get => calisanSayisi;

    }
}

static class Islem
{
    public static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static int Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}
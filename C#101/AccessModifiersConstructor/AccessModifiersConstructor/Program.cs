using System;

namespace AccessModifiersConstructor;

class Program
{
    static void Main(string[] args)
    {
        // [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
        // [Erişim Belirleyici][Geri Dönüş Tipi] MetotAdi([Parametre listesi])
        // {
        // //Metot Komutları
        // }
        // 1. Public : Her yerden erişilebilir.
        // 2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
        // 3. Internal : Sadece bulunduğu proje içerisinden erişilebilir
        // 4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

        Console.WriteLine("********************* calisan1 *********************");
        Calisan calisan1=new Calisan();
        calisan1.Ad="Ayşe";
        calisan1.Soyad="KARA";
        calisan1.No=23425634;
        calisan1.Departman="İnsan Kaynakları";
        calisan1.CalisanBilgileri();

        Console.WriteLine("********************* calisan2 *********************");
        Calisan calisan2=new Calisan();
        
        calisan2.Ad="Deniz";
        calisan2.Soyad="ARDA";
        calisan2.No=25646789;
        calisan2.Departman="Satın Alma";
        calisan2.CalisanBilgileri();

        

        Console.WriteLine("********************* calisan3 *********************");
        Calisan calisan3=new Calisan("Zikriye","ÜRKMEZ",25646736,"Bilişim");
        calisan3.CalisanBilgileri();

        
    }}
class Calisan{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public Calisan(string ad,string soyad, int no,string depertman){
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=depertman;
    }
    public Calisan(string ad,string soyad){
        this.Ad=ad;
        this.Soyad=soyad;
            
    }
    public Calisan(){}

    public void CalisanBilgileri(){
        Console.WriteLine($"Çalışanın Adı : {Ad}");
        Console.WriteLine($"Çalışanın Soyadı : {Soyad}");
        Console.WriteLine($"Çalışanın Nosu : {No}");
        Console.WriteLine($"Çalışanın Depertmanı : {Departman}");
    }
}
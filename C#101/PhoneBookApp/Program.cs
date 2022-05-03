using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneBookList.phoneBookNumber.Add(new PhoneBookNumber("Mehmet", "Menteşe", "542"));
            PhoneBookList.phoneBookNumber.Add(new PhoneBookNumber("Ahmet", "Kaya", "543"));
            PhoneBookList.phoneBookNumber.Add(new PhoneBookNumber("Ziya", "Karaca", "532"));
            PhoneBookList.phoneBookNumber.Add(new PhoneBookNumber("Yalçın", "Yıldız", "535"));
            PhoneBookList.phoneBookNumber.Add(new PhoneBookNumber("Büşra", "Yılmaz", "555"));


            Start();
            Console.WriteLine("Çıkmak İçin Herhangi Bir Tuşa Basınız...");
            Console.ReadKey();

        }

        //Giriş menüsünü yazdıran metodumuz.
        public static void Print()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Çıkmak İçin 1-5 Dışında Her Hangi Bir Şey Girmeniz Yeterlidir.");
        }
        public static void Start()
        {
            Print();
            int select = 0;

            try
            {
                select = int.Parse(Console.ReadLine());
                while (Check(select))
                {
                  

                    if (select == 1)
                    {
                        Save();
                    }
                    else if (select == 2)
                    {
                        Delete();
                    }
                    else if (select == 3)
                    {
                        Update();
                    }
                    else if (select == 4)
                    {
                        PhoneBook();
                    }
                    else if (select == 5)
                    {
                        SearchNumber();
                    }
                    else
                    {
                        Console.WriteLine("1-5 Aralığı Dışında Bir Sayı Girildi, Çıkılıyor...");
                        break;
                    }
                    Print();
                    select = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Sadece int türünde değer girebilirsiniz.");
            }





        }
        //Girilmiş numaranın 1 ile 5 arasında olduğunun kontrolü yapılır.
        public static bool Check(int number)
        {
            if (number >= 1 && number <= 5)
                return true;
            else
                return false;
        }

        //Rehberi Listeleyen metodumuz.
        public static void PhoneBook()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("****************************");
            for (int i = 0; i < PhoneBookList.phoneBookNumber.Count; i++)
            {
                Console.WriteLine("isim: {0}", PhoneBookList.phoneBookNumber[i].Name);
                Console.WriteLine("Soyisim: {0}", PhoneBookList.phoneBookNumber[i].Surname);
                Console.WriteLine("Telefon Numarası: {0}", PhoneBookList.phoneBookNumber[i].Number);
                Console.WriteLine("-");
            }
        }

        //Rehbere yeni kullanıcı kaydeden metodumuz.
        public static void Save()
        {
            Console.WriteLine(" Lütfen isim giriniz             : ");
            string name = Console.ReadLine();
            Console.WriteLine(" Lütfen soyisim giriniz          : ");
            string surname = Console.ReadLine();
            Console.WriteLine(" Lütfen telefon numarası giriniz : ");
            string number = Console.ReadLine();
            PhoneBookList.phoneBookNumber.Add(new PhoneBookNumber(name, surname, number));

        }

        //Rehberden kullanıcı silen metodumuz.
        public static void Delete()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string nameOrSurname = Console.ReadLine();
            PhoneBookNumber phoneNumber = Search(nameOrSurname);

            if (phoneNumber != null)
            {
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", nameOrSurname);
                string s = Console.ReadLine();
                if (s.ToLower() == "y")
                {
                    PhoneBookList.phoneBookNumber.Remove(phoneNumber);
                    Console.WriteLine("Kayıt rehberden başarıyla silindi!");
                }
                else if (s.ToLower() == "n")
                {
                    Console.WriteLine("Kayıt silme onaylanmadı!");
                    Start();
                }
                else
                {
                    Console.WriteLine("Yanlış bir giriş yaptınız!");
                    Start();
                }


            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için    : (1)");
                Console.WriteLine(" * Yeniden denemek için              : (2)");
                string number = Console.ReadLine();
                if (number == "1")
                {
                    Console.WriteLine("Silme işlemi sonlandırılıyor!");
                    Start();
                }
            }



        }
       
      
      

        public static void Update()
        {
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını veya soyadını giriniz : ");
            PhoneBookNumber phoneNumber = Search(Console.ReadLine());
            string[] items =
            {
                "Lütfen İsim Giriniz        : ",
                "Lütfen Soy İsim Giriniz    : ",
                "Lütfen Numara Giriniz      : "
            };
            int itemsLength = items.Length;
            string[] updatePhoneModel = new string[itemsLength];
            if (phoneNumber != null)
            {
                Console.WriteLine("{0} isimli kişi güncellenmek üzere, onaylıyor musunuz ?(y/n)", phoneNumber.Name);
                string s = Console.ReadLine();
                if (s.ToLower() == "y")
                {
                    for (int i = 0; i < itemsLength; i++)
                    {
                        Console.WriteLine(items[i]);
                        items[i] = Console.ReadLine();
                    }

                    phoneNumber.Name = items[0];
                    phoneNumber.Surname = items[1];
                    phoneNumber.Number = items[2];
                    Record(phoneNumber);
                    Console.WriteLine("Kayıt güncelleme başarıyla tamamlandı!");

                }
                else if (s.ToLower() == "n")
                {
                    Console.WriteLine("Kayıt güncelleme onaylanmadı!");
                    Start();
                }
                else
                {
                    Console.WriteLine("Yanlış bir giriş yaptınız!");
                    Start();
                }
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine(" * Yeniden denemek için              : (2)");
                string number = Console.ReadLine();
                if (number == "1")
                {
                    Console.WriteLine("Güncelleme sonlandırılıyor!");
                    Start();
                }
            }
        }

       


        public static void Record(PhoneBookNumber phoneNumbers)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("İsim         :   {{{0}}}", phoneNumbers.Name);
            Console.WriteLine("Soyisim      :   {{{0}}}", phoneNumbers.Surname);
            Console.WriteLine("Numara       :   {{{0}}}", phoneNumbers.Number);
            Console.WriteLine("****************************************");
        }

        public static PhoneBookNumber Search(string s)
        {
            bool isExist = false;
            foreach (var item in PhoneBookList.phoneBookNumber)
            {
                if (item.Name == s || item.Surname == s)
                {
                    isExist = true;
                    if (isExist)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static void SearchNumber()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("***********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını ya da soyadını giriniz:");
                string name = Console.ReadLine();
                foreach (var item in PhoneBookList.phoneBookNumber)
                {
                    if (item.Name.ToLower() == name.ToLower() || item.Surname.ToLower() == name.ToLower())
                    {
                        Console.WriteLine("isim: {0}", item.Name);
                        Console.WriteLine("Soyisim: {0}", item.Surname);
                        Console.WriteLine("Telefon Numarası: {0}", item.Number);
                        Console.WriteLine("-");
                    }
                }
                Console.WriteLine("Arama İşlemi Bitti, Çıkılıyor...");
            }
            else if (select == 2)
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin telefon numarasını giriniz:");
                string no = Console.ReadLine();
                foreach (var item in PhoneBookList.phoneBookNumber)
                {
                    if (item.Number == no)
                    {
                        Console.WriteLine("isim: {0}", item.Name);
                        Console.WriteLine("Soyisim: {0}", item.Surname);
                        Console.WriteLine("Telefon Numarası: {0}", item.Number);
                        Console.WriteLine("-");
                    }
                }
                Console.WriteLine("Arama İşlemi Bitti, Çıkılıyor...");
            }
            else
            {
                Console.WriteLine("Hatalı Seçim, Çıkılıyor...");
            }


        }




    }



    public class PhoneBookList
    {
        public static List<PhoneBookNumber> phoneBookNumber = new List<PhoneBookNumber>();
    }

    //Bu bölümde Telefon Rehberi Uygulamamızda sabit olan her bir kişi için isim, soyisim ve numara değişkenlerinin modeli oluşturularak kullanılabilir hale getirildi.

    public class PhoneBookNumber
    {


        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
       
        public PhoneBookNumber(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }



    }

}


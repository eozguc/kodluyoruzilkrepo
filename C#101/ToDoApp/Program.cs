using System;
using System.Collections.Generic;


namespace ToDoApp
{
    public class Program
    {
        public static Board _board { get; set; }
        public static UserList _userList { get; set; }
        static void Main(string[] args)
        {
            _board = new Board();
            _userList = new UserList();

            while (true)
            {
                Page();
            }
        }


        public static void Page()
        {
            int check;
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");// getBoard ve printLine metotları çağrılır.
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            check = Int32.Parse(Console.ReadLine());

            switch (check)
            {
                case 1:
                    GetBoard();
                    break;
                case 2:
                    NewCard();
                    break;
                case 3:
                    RemoveCard();
                    break;
                case 4:
                    MoveCard();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız!");
                    break;
            }
        }

        public static void GetBoard()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("*********************");

            if (_board.TODO.Count > 0)
                PrintLine(_board.TODO, _userList);
            else
                Console.WriteLine("~BOŞ~");
            /////////////////////////////////////////////////
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*********************");

            if (_board.IN_PROGRESS.Count > 0)
                PrintLine(_board.IN_PROGRESS, _userList);
            else
                Console.WriteLine("~BOŞ~");
            /////////////////////////////////////////////////
            Console.WriteLine("DONE Line");
            Console.WriteLine("*********************");
            if (_board.DONE.Count > 0)
                PrintLine(_board.DONE, _userList);
            else
                Console.WriteLine("~BOŞ~");

        }


        //Kolanları yazdıran Metot
        public static void PrintLine(List<Card> col, UserList userList)
        {
            foreach (var item in col)
            {
                Console.WriteLine("Başlık      : {0}", item.Title);
                Console.WriteLine("İçerik      : {0}", item.Content);
                Console.WriteLine("Atanan Kişi : {0}", userList.all.Find(x => x.Id == item.Id).FullName);
                Console.WriteLine("Büyüklük    : {0}", ((Size)item.Size).ToString());
                Console.WriteLine("-");
            }
        }

        private static void NewCard()
        {
            string title;
            string content;
            int size;
            int memberId;

            Console.WriteLine("Başlık Giriniz                                  :");
            title = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                  :");
            content = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            size = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kişi Seçiniz (1-5 arası bir rakam)              :");
            memberId = Int32.Parse(Console.ReadLine());

            _board.TODO.Add(new Card(title, content, memberId, size));

        }

        //Kart silme
        private static void RemoveCard()
        {
            string title;
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            title = Console.ReadLine();

            int todo;
            int inProgress;
            int done;

            todo = _board.TODO.FindIndex(x => x.Title.ToLower() == title.ToLower());
            inProgress = _board.TODO.FindIndex(x => x.Title == title.ToLower());
            done = _board.TODO.FindIndex(x => x.Title == title.ToLower());

            if (todo >= 0)
                _board.TODO.RemoveAt(todo);
            else if (inProgress >= 0)
                _board.IN_PROGRESS.RemoveAt(inProgress);
            else if (done >= 0)
                _board.DONE.RemoveAt(done);
            else
            {
                Console.WriteLine("Aradığınız kart bulunamadı.");
                Page();
            }
            Console.WriteLine("İşlem başarılı bir şekilde tamamlandı.");
        }

        private static void MoveCard()
        {
            //4 işlem: index al, kartı al, eski karttan sil ve yeniye ekle
            //string _title, _line = String.Empty;
            string title = "";
            string line = "";
            Card card = new Card(null, null, -1, -1);
            int index = -1;
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor. ");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            title = Console.ReadLine();
            int todo;
            int inProgress;
            int done;

            todo = _board.TODO.FindIndex(x => x.Title.ToLower() == title.ToLower());
            inProgress = _board.IN_PROGRESS.FindIndex(x => x.Title.ToLower() == title.ToLower());
            done = _board.DONE.FindIndex(x => x.Title.ToLower() == title.ToLower());

            //kart varsa çekip ekranda göster
            if (todo >= 0)
            {
                line = "TODO";
                index = todo;
            }
            else if (inProgress >= 0)
            {
                line = "IN_PROGRESS";
                index = inProgress;
            }
            else if (done >= 0)
            {
                line = "DONE";
                index = done;
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun card board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int check = int.Parse(Console.ReadLine());

                if (check == 1)
                {
                    Page();
                }
                else if (check == 2)
                {
                    MoveCard();
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem seçtiniz. İşlem sonlandırılıyor.");
                    Page();
                }
            }

            if (line is not null)
            {
                card = _board.GetProperty(line).Find(x => x.Title.ToLower() == title.ToLower());
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine("Başlık      : {0}", card.Title);
                Console.WriteLine("İçerik      : {0}", card.Content);
                Console.WriteLine("Atanan Kişi : {0}", _userList.all.Find(x => x.Id == card.Id).FullName);
                Console.WriteLine("Büyüklük    : {0}", ((Size)card.Size).ToString());
                Console.WriteLine("Line        : {0}", line);

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");

                int _check1 = int.Parse(Console.ReadLine());

                if (_check1 == 1)
                {
                    _board.GetProperty(line).RemoveAt(index);
                    _board.TODO.Add(card);
                }
                else if (_check1 == 2)
                {
                    _board.GetProperty(line).RemoveAt(index);
                    _board.IN_PROGRESS.Add(card);
                }
                else if (_check1 == 3)
                {
                    _board.GetProperty(line).RemoveAt(index);
                    _board.DONE.Add(card);
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem seçtiniz. İşlem sonlandırılıyor.");
                    Page();
                }
                GetBoard();
            }


        }
    }

    public enum Size
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }

    public class Board
    {
        public List<Card> TODO = new List<Card>();
        public List<Card> IN_PROGRESS = new List<Card>();
        public List<Card> DONE = new List<Card>();

        public Board()
        {
            TODO.Add(new Card("Homework", "Javascript modülünü tamamla.", 1, 1));
            IN_PROGRESS.Add(new Card("Coderbyte Challenge", "C# Coderbyte Challege'ını çöz.", 2, 2));
            DONE.Add(new Card("Build", "ToDoList Projesinin build'ini al.", 3, 3));
        }

        public List<Card> GetProperty(string str)
        {
            if (str == "TODO")
                return this.TODO;
            else if (str == "IN_PROGRESS")
                return this.IN_PROGRESS;
            else
                return this.DONE;
        }

       


    }
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }
        public int Size { get; set; }
        public Card(string title, string content, int id, int size)
        {
            Title = title;
            Content = content;
            Id = id;
            Size = size;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public User(int id, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
        }

    }

    public class UserList
    {
        public List<User> all = new List<User>();

        public UserList()
        {
            all.Add(new User(1, "Ziya Karaca"));
            all.Add(new User(2, "Mehmet Sezer"));
            all.Add(new User(3, "Yalçın Yıldız"));
            all.Add(new User(4, "Ahmet Kaya"));
        }

    }
}

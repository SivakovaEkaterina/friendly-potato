namespace Zapisnay_knijka
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            date = DateTime.Today;
            
            string idate = date.ToShortDateString();
            Date(date, idate);
            
            int b = 1;
            ConsoleKeyInfo a;
            a = Console.ReadKey();
            Information(date, a, idate);
            Console.Clear();
            
            while (b == 1)
            {
                 
                if (a.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(1);
                }
                if (a.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }
                 
                idate = date.ToShortDateString();
                Date(date, idate);
                Information(date, a, idate);
                a = Console.ReadKey();
                Console.Clear();
            }

        }

        static void Date(DateTime date, string idate)
        {
            //Console.WriteLine(date.ToString("dddd, dd.MM.yyyy"));
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Воскресенье " + idate);
                Console.WriteLine("Выходной");
            }
            if (date.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("Понедельник " + idate);
            }
            if (date.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("Вторник " + idate);
            }
            if (date.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Среда " + idate);
            }
            if (date.DayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine("Четверг " + idate);
            }
            if (date.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("Пятница " + idate);
            }
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Суббота " + idate);
            }
        }
        static int Strelki(ConsoleKeyInfo a, int p)
        {

            if (a.Key == ConsoleKey.DownArrow)
            {
                p++;
            }
            if (a.Key == ConsoleKey.UpArrow)
            {
                p--;
            }

            if (p == 0)
            {
                p = 1;
            }
            return p;
            
        }
       
        static void Information(DateTime date, ConsoleKeyInfo a, string idate)
        {
            Infor ifo = new Infor();
            Infor ifo1 = new Infor();
            int p = 1;

            if (idate == "21.10.2022")
            {
                ifo.Name = "Сходить в тех";
                
                ifo1.Name = "Понять в чём проблема этой программы ( qq)";
                
                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ifo.Name);
                Console.SetCursorPosition(2, 2);
                Console.WriteLine(ifo1.Name);
                int f = 0;

                if (a.Key == ConsoleKey.DownArrow)
                {
                    while (f == 0)
                    {
                        Console.Clear();
                        int d = Strelki(a, p);
                        Date(date, idate);
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine(ifo.Name);
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine(ifo1.Name);
                        Console.SetCursorPosition(0, d);
                        Console.WriteLine("->");
                        
                        a = Console.ReadKey();
                        if (a.Key == ConsoleKey.Enter)
                        {
                            if (d == 1)
                            {
                                ifo.Info = "Сходить в техникум и получить оценки";
                                ifo.Datehover = "12:";
                                ifo.Datemin = "30";
                                a = Vivod(a, ifo);
                            }
                            if (d == 2)
                            {
                                ifo.Name = "Понять в чём проблема этой программы ( qq)";
                                ifo.Info = "Попросить помощи у Софьи Алексеевны";
                                ifo.Datehover = "12:";
                                ifo.Datemin = "00";
                                a = Vivod(a, ifo);
                            }
                        }
                        if (a.Key == ConsoleKey.Escape)
                        {
                            f++;
                        }
                    }

                }
            }
            if (idate == "24.10.2022")
            {
                ifo.Name = "Отдохнуть";

                ifo1.Name = "Погулять";

                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ifo.Name);
                Console.SetCursorPosition(2, 2);
                Console.WriteLine(ifo1.Name);
                int f = 0;

                if (a.Key == ConsoleKey.DownArrow)
                {
                    while (f == 0)
                    {
                        Console.Clear();
                        int d = Strelki(a, p);
                        Date(date, idate);
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine(ifo.Name);
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine(ifo1.Name);
                        Console.SetCursorPosition(0, d);
                        Console.WriteLine("->");
                        
                        a = Console.ReadKey();
                        if (a.Key == ConsoleKey.Enter)
                        {
                            if (d == 1)
                            {
                                ifo.Info = "Отдохнуть и погулять";
                                ifo.Datehover = "10:";
                                ifo.Datemin = "00";
                                a = Vivod(a, ifo);
                            }
                            if (d == 2)
                            {
                                ifo.Name = "Погулять";
                                ifo.Info = "Погулять и отдохнуть";
                                ifo.Datehover = "12:";
                                ifo.Datemin = "00";
                                a = Vivod(a, ifo);
                            }
                        }
                        if (a.Key == ConsoleKey.Escape)
                        {
                            f++;
                        }
                    }

                }
            }
            if (idate == "22.10.2022")
            {
                ifo.Name = "Сходить в магазин";
                ifo.Info = "Сходить в магазин и купить продуктов";
                ifo.Datehover = "14:";
                ifo.Datemin = "00";

                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ifo.Name);

                
                if (a.Key == ConsoleKey.Enter)
                {
                    a = Vivod(a, ifo);
                }
            }
            if (idate == "25.10.2022")
            {
                ifo.Name = "Люблю программировать...";
                ifo.Info = "Люблю программировать и понимать что я делаю. ПАМАГИТЕ.";
                ifo.Datehover = "23:";
                ifo.Datemin = "59";

                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ifo.Name);


                if (a.Key == ConsoleKey.Enter)
                {
                    a = Vivod(a, ifo);
                }
            }
            if (idate == "12.11.2022")
            {
                ifo.Name = "День рождения";
                ifo.Info = "Сходить в техникум и отпраздновать др";
                ifo.Datehover = "8:";
                ifo.Datemin = "30";

                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ifo.Name);

                
                if (a.Key == ConsoleKey.Enter)
                {
                    Vivod(a, ifo);
                }
            }
            
        }
        static ConsoleKeyInfo Vivod(ConsoleKeyInfo a, Infor ifo)
        {
            List<Infor> list = new List<Infor>();
            list.Add(ifo);
            int d = 1;
            while (d == 1)
            {
                Console.Clear();
                foreach (Infor info in list)
                {
                    Console.WriteLine(info.Name);
                    Console.WriteLine(info.Info);
                    Console.WriteLine(info.Datehover + info.Datemin);
                    Console.WriteLine("--------------");
                }
                    
                a = Console.ReadKey();
                
                if (a.Key == ConsoleKey.Escape)
                {
                    d = 0;
                }  
                
            }
            return a;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person : IPerson
    {
        public string name;
        public int age;
        public virtual void Move()
        {
            Console.WriteLine("Человек идет");
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(name))
            {
                return "Имя не определено";
            }
            return "Продюссера зовут " + name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }

    interface ITVprogram
    {
        void Watch();
    }

    interface IPerson
    {
        void Move();
    }

    class TVprogram 
    {
        public int agelimit;
        public double time;
    }

    class Film : TVprogram, ITVprogram
    {
        private int year;
        static int limit = 16;
        
       
        public Film(int ch)
        {
            year = ch;
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Фильм начнется через 20 мин");
            }
            else
            {
                Console.WriteLine("Вам рано еще смотреть этот фильм");
            }
        }
        public override string ToString()
        {
            return $"Возрастное ограничение на просмотр этого фильма {agelimit}";
        }
    }

    class News : TVprogram, ITVprogram
    {
        public static int count = 0;
        static int limit = 18;
        public News(int age)
        {
            agelimit = age;
            count++;
        }
        public override string ToString()
        {
            return $"Возрастное ограничение этих новостей {limit}";
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Новости начнутся через 20 мин");
            }
            else
            {
                Console.WriteLine("Вам рано смотреть");
            }
        }
    }

    class Cartoon : TVprogram, ITVprogram
    {
        static int limit = 8;
        public Cartoon(int age)
        {
            agelimit = age;
        }
        public override string ToString()
        {
            return $"Возрастное ограничение этого мультфильма {limit}";
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Мультфильм начнется через 20 мин");
            }
            else
            {
                Console.WriteLine("Вам нельзя это смотреть");
            }
        }
    }

    sealed class Producer : Person
    {
        public string education;
        public override void Move()
        {
            Console.WriteLine($"{name} идет");
        }

    }


    public class Printer
    {
        public void IAmPrinting(object obj)
        {
            obj.GetType();
            Console.WriteLine(obj.ToString());
        }
    }


    /// <summary>
    /// 6 laba
    /// </summary>


    
    public class ProgramGuide
    {
        private int yer;
        public int vremya;
        public ProgramGuide()
        {

        }
        public ProgramGuide(int vr)
        {
            vremya = vr;
        }
        public void Inf()
        {
            Console.WriteLine($"Продолжительность передачи {vremya + time}");
        }
        public static int time = 20;
        public int Year
        {
            get
            {
                return yer;
            }
            set
            {
                if (value > 0)
                {
                    yer = value;
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
            }
        }
        public static int year = 2015;
        internal List<ProgramGuide> Spis = new List<ProgramGuide>();
        void Add(ProgramGuide c)
        {
            Spis.Add(c);
            Console.WriteLine($"В список добавлен {c}");
        }
        void Remove(ProgramGuide c)
        {
            Spis.Remove(c);
            Console.WriteLine($"Из списка удален {c}");
        }
        void Output(List<ProgramGuide> c)
        {
            foreach(object ch in c)
            {
                Console.WriteLine(ch);
            }
        }
        
        
        
    }
    class Controller
    {
        List<object> l = new List<object>();
        
       public static void Count()
        {
            Console.WriteLine($"Число рекламных роликов равно {News.count}");
        }
        public static void Search(List<ProgramGuide> spis)
        {
            for(int i=0;i<spis.Count; i++)
            {
                if(spis[i].Year == ProgramGuide.year)
                {
                    Console.WriteLine($"{spis[i]} снимался в 2015 году");
                }
                else
                {
                    Console.WriteLine($"{spis[i]} не снимался в 2015 году");
                }
            }
        }
    }
    struct User
    {
        public string Name;
        public int Age;
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Info()
        {
            Console.WriteLine($"Имя юзера {Name}, его возраст {Age}");
        }
    }

    enum obj
    {
        Monday,
        Tuesday,
        Whensday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }



    public partial class Olya
    {
        public string name;
    }


    public partial class Olya
    {
        public string Age;
    }
}

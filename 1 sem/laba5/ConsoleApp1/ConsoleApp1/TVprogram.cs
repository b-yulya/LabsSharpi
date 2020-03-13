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

    abstract class TVprogram
    {
        public int agelimit;
        public abstract void Watch();
    }

    class Film : TVprogram
    {
        static int limit = 16;
        public Film(int age)
        {
            agelimit = age;
        }
        public override void Watch()
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
        static int limit = 18;
        public News(int age)
        {
            agelimit = age;
        }
        public override string ToString()
        {
            return $"Возрастное ограничение этих новостей {limit}"; 
        }
        public override void Watch()
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
        public override void Watch()
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
}

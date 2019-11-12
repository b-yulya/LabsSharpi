using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    interface IGeneric<T> where T : struct
    {
        void Ad(T item);
        void Remove(T item);
        void Display(Seet<T> Items);
    }
    public class Seet <T> : IGeneric<T> where T : struct
    {
        public List<T> Spis = new List<T>();
        public void Ad(T item)
        {
            if (!Spis.Contains(item))
            {
                Spis.Add(item);

            }
            
        }

        public void Remove(T item)
        {
            if (Spis.Contains(item))
            {
                Spis.Remove(item);
            }
        }

        public void Display(Seet<T> Item)
        {
            foreach(T ch in Item.Spis)
            {
                Console.Write($"{ch}  ");
            }
            Console.WriteLine();
        }

        public static int count;
        public Seet()
        {
            count++;
            Console.WriteLine($"Создано {count}-е множество");
        }
        public List<T> Items = new List<T>();

        public void Add(T _item)
        {
            if (!Items.Contains(_item))
            {
                Items.Add(_item);

            }
        }
        public static string operator >(T elem, Seet<T> item)
        {

            if (item.Items.Contains(elem))
            {
                return $"{elem} находится в {item}";
            }
            else
            {
                return $"{elem} нету в {item}";
            }
        }
        public static string operator <(T item1, Seet<T> item2)
        {
            if (!item2.Items.Contains((item1)))
            {
                return $"{item1} нету в {item2}";
            }
            else
            {
                return $"{item1} есть в {item2}";
            }
        }
        public static string operator *(Seet<T> item1, Seet<T> item2)
        {
            List<T> item3 = new List<T>();
            Console.WriteLine("Пересечение множеств");
            foreach (T ch in item1.Items)
            {
                if (item2.Items.Contains(ch))
                {
                    item3.Add(ch);
                }

            }
            foreach (T cc in item3)
            {
                Console.WriteLine(cc);
            }
            return null;
        }

        public class Date
        {
            public static int count = 1;
            public string createdate;
            public Date()
            {

                createdate = DateTime.Now.ToString();
                Console.WriteLine($"Время создания {count} объекта {createdate}");
                count++;
            }
        }
        public class Owner
        {
            public int id = 5;
            public string name = "Andrey";
            public string organization = "EPAM";
        }





    }


}

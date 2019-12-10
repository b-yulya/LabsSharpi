using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Seet 
    {


        public int lot1 { get; set; }
        public int lot2 { get; set; }
        public int lot3 { get; set; }
        public int lot4 { get; set; }
        public int lot5 { get; set; }

        public Seet(int a, int b, int c, int d, int e)
        {
            this.lot1 = a;
            this.lot2 = b;
            this.lot3 = c;
            this.lot4 = e;
            this.lot5 = d;
        }
        public static int count;
        public Seet()
        {
            count++;
            Console.WriteLine($"Создано {count}-е множество");
        }
        public List<int> Items = new List<int>();

        public void Add(int _item)
        {
            if (!Items.Contains(_item))
            {
                Items.Add(_item);

            }
        }
        public static string operator >(int elem, Seet item)
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
        public static string operator <(int item1, Seet item2)
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
        public static string operator *(Seet item1, Seet item2)
        {
            List<int> item3 = new List<int>();
            Console.WriteLine("Пересечение множеств");
            foreach (int ch in item1.Items)
            {
                if (item2.Items.Contains(ch))
                {
                    item3.Add(ch);
                }

            }
            foreach (int cc in item3)
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
            public static explicit operator string(Date a)
            {
                return a.createdate;
            }
        }
        public class Owner
        {
            public int id = 5;
            public string name = "Andrey";
            public string organization = "EPAM";
        }
        public static void Sum(List<int> obj)
        {
            int Sum = 0;
            foreach(int ch in obj)
            {
                Sum += ch;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Items).GetEnumerator();
        }
    }


}

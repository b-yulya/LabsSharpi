using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Seet
    {
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
            public static int coont = 1;
            public string createdate;
            public Date()
            {

                createdate = DateTime.Now.ToString();
                Console.WriteLine($"Время создания {coont} объекта {createdate}");
                coont++;
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

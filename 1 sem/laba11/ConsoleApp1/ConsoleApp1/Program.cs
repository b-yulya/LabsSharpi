
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Mounth = { "January", "February", "March", "April", "May", "June", "July", "August",
                "September", "October", "November", "December"};

            var SelectMounth = Mounth.Where(t => t.Length > 4 && t.Contains('u')).OrderBy(t => t);

            foreach (string ch in SelectMounth)
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine();
            var WinnerSummer = Mounth.Where(t => t.Contains("January") || t.Contains("February")
            || t.Contains("December") || t.Contains("June") || t.Contains("July") || t.Contains("August")).Select(t => t);
            foreach (string wn in WinnerSummer)
            {
                Console.WriteLine(wn);
            }




            List<Seet> obj = new List<Seet>();
            obj.Add(new Seet(-3, 6, 7, 12, 4));
            obj.Add(new Seet(7, 1, 9, 22, 14));
            obj.Add(new Seet(3, 5, 2, 13, 12));
            obj.Add(new Seet(1, 6, 4, 17, 45));

            var MaxElem = obj.Max(t => t.lot1 + t.lot2 + t.lot3 + t.lot4 + t.lot5);
            var MinElem = obj.Min(t => t.lot1 + t.lot2 + t.lot3 + t.lot4 + t.lot5);
            var Minus = obj.Where(t => t.lot1 < 0 || t.lot2 < 0 || t.lot3 < 0 || t.lot4 < 0 || t.lot5 < 0).Select(t => t);
            var Znach = obj.Where(t => t.lot1 == 12 || t.lot2 == 12 || t.lot3 == 12 || t.lot4 == 12 || t.lot5 == 12).Count();
            var Opr = obj.Where(t => t.lot1 == 12 || t.lot2 == 12 || t.lot3 == 12 || t.lot4 == 12 || t.lot5 == 12).First();
            var Order = obj.OrderBy(t => t.lot1).Select(t => t);
            Console.WriteLine("Максимальная сумма:");
            Console.WriteLine(MaxElem);
            Console.WriteLine("Минимальная сумма:");
            Console.WriteLine(MinElem);
            Console.WriteLine("Множествова с отрицательными элементами:");
            foreach (Seet ch in Minus)
            {
                Console.WriteLine(ch.lot1 + " " + ch.lot2 + " " + ch.lot3 + " " + ch.lot4 + " " + ch.lot5);
            }
            Console.WriteLine("Кол-во множеств с определенным значением: ");
            Console.WriteLine(Znach);
            Console.WriteLine("Первое множество с определенным значением: ");
            foreach (Seet ch in Opr)
            {
                Console.WriteLine(ch.lot1 + " " + ch.lot2 + " " + ch.lot3 + " " + ch.lot4 + " " + ch.lot5);
            }
            Console.WriteLine("Упорядоченные множества по первому элементу:");
            foreach (Seet ch in Order)
            {
                Console.WriteLine(ch.lot1 + " " + ch.lot2 + " " + ch.lot3 + " " + ch.lot4 + " " + ch.lot5);
            }

            List<int> list1 = new List<int>();
            list1.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            List<int> list2 = new List<int>();
            list2.AddRange(new int[] { 2, 4, 6, 8, 10 });

            var selectedList = from t1 in list1
                               join t2 in list2 on t1 equals t2
                               orderby t1
                               select t1;

            Console.Write("\nTask 4: ");
            foreach (var s in selectedList)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            int rere = list1.Aggregate((x, y) => x + y);
            Console.WriteLine(rere);



        }
    }
}

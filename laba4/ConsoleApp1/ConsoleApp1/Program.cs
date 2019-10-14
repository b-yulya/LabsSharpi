using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Seet kek = new Seet();
            kek.Add(5);
            kek.Add(3);
            kek.Add(2);
            kek.Add(7);
            kek.Add(-3);
            kek.Add(-1);
            Seet kek2 = new Seet();
            kek2.Add(1);
            kek2.Add(2);
            kek2.Add(3);
            kek2.Add(7);
            Seet kek3 = new Seet();
            var qw = 3 > kek2;
            var qwe = 6 < kek;
            var qqq = kek * kek2;
            Console.WriteLine(qw);
            Console.WriteLine(qwe);
            Console.WriteLine(qqq);
            Seet.Date Create = new Seet.Date();
            Seet.Date Create2 = new Seet.Date();
            Seet.Owner pro = new Seet.Owner();
            StaticOperation.Difference(kek2);
            StaticOperation.Sum(kek2);
            StaticOperation.Count(kek2);
            string stroka = "Andrey21";
            Console.WriteLine(stroka);
            StaticOperation.Sub(stroka);
            StaticOperation.Plus(kek, kek3);
            
            


        }
    }
}

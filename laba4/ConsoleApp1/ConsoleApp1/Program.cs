using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Seet obj1 = new Seet();
            obj1.Add(5);
            obj1.Add(3);
            obj1.Add(2);
            obj1.Add(7);
            obj1.Add(-3);
            obj1.Add(-1);
            Seet obj2 = new Seet();
            obj2.Add(1);
            obj2.Add(2);
            obj2.Add(3);
            obj2.Add(7);
            Seet obj3 = new Seet();
            var qw = 3 > obj2;
            var qwe = 6 < obj1;
            var qqq = obj1 * obj2;
            Console.WriteLine(qw);
            Console.WriteLine(qwe);
            Console.WriteLine(qqq);
            Seet.Date Create = new Seet.Date();
            Seet.Date Create2 = new Seet.Date();
            Seet.Owner pro = new Seet.Owner();
            StaticOperation.Difference(obj2);
            StaticOperation.Sum(obj2);
            StaticOperation.Count(obj2);
            string stroka = "Andrey21";
            Console.WriteLine(stroka);
            StaticOperation.Sub(stroka);
            StaticOperation.Plus(obj1, obj3);






            Seet.Date data = new Seet.Date() { createdate = "21.03.2000" };
            string x = (string)data;
            Console.WriteLine(x);
            


        }
    }
}

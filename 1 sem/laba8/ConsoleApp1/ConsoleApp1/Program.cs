using System;

namespace ConsoleApp1
{

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                // Seet<Film> film = new Seet<Film>();
                Seet<int> obj1 = new Seet<int>();
                obj1.Add(5);
                obj1.Add(3);
                obj1.Add(2);
                obj1.Add(7);
                obj1.Add(-3);
                obj1.Add(-1);
                Seet<int> obj2 = new Seet<int>();
                obj2.Add(1);
                obj2.Add(2);
                obj2.Add(3);
                obj2.Add(7);
                Seet<int> obj3 = new Seet<int>();
                var qw = 3 > obj2;
                var qwe = 6 < obj1;
                var qqq = obj1 * obj2;
                Console.WriteLine(qw);
                Console.WriteLine(qwe);
                Console.WriteLine(qqq);
                Seet<int>.Date Create = new Seet<int>.Date();
                Seet<int>.Date Create2 = new Seet<int>.Date();
                Seet<int>.Owner pro = new Seet<int>.Owner();
                StaticOperation.Difference(obj2);
                StaticOperation.Sum(obj2);
                StaticOperation.Count(obj2);
                string stroka = "Andrey21";
                Console.WriteLine(stroka);
                StaticOperation.Sub(stroka);
                StaticOperation.Plus(obj1, obj3);


                Seet<int> obj5 = new Seet<int>();
                obj5.Ad(4);
                obj5.Ad(7);
                obj5.Display(obj5);
                Seet<double> obj6 = new Seet<double>();
                obj6.Ad(2.5);
                obj6.Ad(3.9);
                obj6.Display(obj6);
            }

            finally
            {
                Console.WriteLine("End.");
            }


        }
    }
}

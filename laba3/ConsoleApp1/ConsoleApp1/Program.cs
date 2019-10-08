using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone Android = new Phone();
            Phone Android2 = new Phone();
            Phone Android3 = new Phone("kek", "12341234");
            Console.WriteLine(Android3);
            Phone.Info();

            int x = 5;
            int y;
            Phone.Sum(ref x, out y);
            Console.WriteLine($"x = {x} y = {y}");


        }
    }
}

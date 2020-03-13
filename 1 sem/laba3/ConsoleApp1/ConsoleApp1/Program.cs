using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone Android = new Phone("Android");
            Phone Android2 = new Phone("Xiomi");
            Phone Android3 = new Phone("Iphone", "12341234");
            Android.TimeCity = 123;
            Android.LongDistance = 0;
            Android2.TimeCity = 345;
            Android2.LongDistance = 23;
            Android3.TimeCity = 0;
            Android3.LongDistance = 50;
            Android.Credit(25);
            Android.Credit(40);
            Android.Balans();
             
            Console.WriteLine(Android3);
            Phone.Info();
            Console.WriteLine(Android.GetType());

            int x = 5;
            int y;
            Phone.Sum(ref x, out y);
            Console.WriteLine($"x = {x} y = {y}");
            Phone[] arr = new Phone[] { Android, Android2, Android3 };
            for (int i = 0; i < 3; i++)
            {
                if (arr[i].longdistance > 0) {
                  
                    Console.WriteLine($"{arr[i].Name} пользовался междугородней связью");
                } else
                {
                    Console.WriteLine($"{arr[i].Name} не пользовался междугородней связью");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if(arr[i].timesity > Phone.NUM)
                {
                    Console.WriteLine($"У {arr[i].Name} время внутригородских разгвооров превышает заданное");
                }
                else
                {
                    Console.WriteLine($"У {arr[i].Name} время не превышает заданное");
                }
            }
            


        }
    }
}

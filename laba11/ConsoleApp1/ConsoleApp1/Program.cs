
using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.MinValue;
            Console.WriteLine(a);
            string q = Console.ReadLine();
            string w = Console.ReadLine();
            string e = q + w;
            Console.WriteLine(e);
            int[] array = new int[8];
            for(int i =0; i < 8; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
                
                
            }
            for (int i = 0; i < 8; i++)
            {
                Console.Write(array[i]);
                if (i == 2)
                {
                    Console.WriteLine();
                }

            }
            Time one = new Time();
            one.minutes = 43;
            Time two = new Time();
            two.minutes = 45;
            Time three = new Time();
            two.minutes = 44;
            Console.WriteLine(one<two);
            Console.WriteLine(two<three);
            Console.WriteLine(two==three);
            Console.WriteLine(one==one);
            Student Andrey = new Student();
            Andrey.Study();
            Prepod Pasha = new Prepod();
            Pasha.Study();
            



        }
    }

    interface IStudy
    {
        void Study();
    }


    class Student : IStudy
    {
        public void Study()
        {
            Console.WriteLine("Я учусь");
        }
    }

    class Prepod : Student, IStudy
    {
        public void Study() : base()
        {
            Console.WriteLine("Учу");
        }
    }

    class Time
    {
        static bool aa;
        static string bb;
        const int HOURS = 22;
        public int minutes;
        int seconds;

       public static bool operator <(Time a, Time b)
        {
            if(a.minutes < b.minutes)
            {
                aa = true;
            }
            else
            {
                aa = false;
            }
            return aa;
        }
        public static bool operator >(Time a, Time b)
        {
            if (a.minutes > b.minutes)
            {
                aa = true;
            }
            else
            {
                aa = false;
            }
            return aa;
            
        }
        public static string operator ==(Time a, Time b)
        {
            if (a.Equals(b))
            {
               bb = $"{a} равен {b}";
            }
            else
            {
                bb = $"{a} неравен {b}";
            }
            return bb;
        }
        public static string operator !=(Time a, Time b)
        {
            if (!a.Equals(b))
            {
                bb = $"{a} неравен {b}";
            }
            else
            {
                bb = $"{a} равен {b}";
            }
            return bb;
        }

    }
}

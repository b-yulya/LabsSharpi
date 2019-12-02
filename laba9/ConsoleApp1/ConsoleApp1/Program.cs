
using System;
using System.Text;

namespace ConsoleApp1
{

    public static class StrUpgrade
    {
        public static Func<string, string> StrFunc;
        public static Action<string> action;

        private static string AddDot(string str)
        {
            str += ".";
            return str;
        }
        private static void SubString(string str)
        {
            Console.WriteLine(str.Substring(0,5));
        }
        private static string RemoveDoubleSpaces(string str)
        {

            return str.Replace(" ", "_");
        }
        private static string ToUpperCase(string str)
        {

            return str.ToUpper();
        }
        private static string RemoveCom(string str)
        {
            return str.Replace(", ", " ");
        }

        public static void Upgrade(string str)
        {

            StrFunc = RemoveCom;
            StrFunc?.Invoke(str);
            Console.WriteLine(StrFunc(str));
            StrFunc += ToUpperCase;
            StrFunc?.Invoke(str);
            Console.WriteLine(StrFunc(str));
            StrFunc += RemoveDoubleSpaces;
            StrFunc?.Invoke(str);
            Console.WriteLine(StrFunc(str));
            StrFunc += AddDot;
            StrFunc?.Invoke(str);
            Console.WriteLine(StrFunc(str));
            action = SubString;
            action?.Invoke(str);


        }
    }
    class Boss
    {
        public static int Age;
        static bool OnOff = false;
        static int pers = 220;
        static int tech = 500;
        public static int volt;
        public static int AreVolt;
        public int Volt
        {
            get
            {
                return volt;
            }
            set
            {
                if (value > 0)
                {
                    volt = value;
                }
            }
        }
        public delegate void Technics(string str);
        public event Technics Upgrade;
        public event Technics TurnOn;
        public Boss(int age)
        {
            Age = age;
        }
        public void On()
        {
            OnOff = true;
            Upgrade?.Invoke("Техника включена");
        }
        public void Add(int vlt)
        {
            if(OnOff == true)
            {
                volt += vlt;
                AreVolt += vlt;

                if(volt < tech )
                {
                    TurnOn?.Invoke($"Мощность увеличина на {vlt}");
                    TurnOn?.Invoke($"(В настоящий момент мощность техники {volt})");
                    
                }
                else
                {
                    Console.WriteLine("Техника сломалась");
                }
                if(AreVolt < pers)
                {
                    TurnOn?.Invoke($"(В настоящий момент мощность человека {AreVolt})");
                }
                else
                {
                    Console.WriteLine("Человек сломался");
                }

            }
            else
            {
                Console.WriteLine("Вы не включили технику");
            }

        }
        

    }
    class Program
    {   

        static void Main(string[] args)
        {
            Boss boss1 = new Boss(18);
            boss1.Upgrade += st => Console.WriteLine(st);
            boss1.TurnOn += st => Console.WriteLine(st);
            boss1.Volt = 100;
            boss1.Add(70);
            boss1.On();
            boss1.Volt = 100;
            boss1.Add(70);
            boss1.Add(400);
            string str = "Hello, How are you?";
            Console.WriteLine(str);
            StrUpgrade.Upgrade(str);
            

        }
        
    }
}

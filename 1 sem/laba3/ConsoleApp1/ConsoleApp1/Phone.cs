using System;
namespace ConsoleApp1
{
    partial class Phone
    {
        static public readonly string ID = "qwe";
        public const int NUM =30;
        static public int count;
        private int number;
        public int timesity;
        public int longdistance;
        public string Name;
        private string Adress { get; set; }
        private int balance;
        public int credit;

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(value > 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if(value > 0)
                {
                    number = value;
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
            }
        }
        public int TimeCity
        {
            get
            {
                return timesity;
            }
            set
            {
                if (value > 0)
                {
                    timesity = value;
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
            }
        }
        public int LongDistance
        {
            get
            {
                return longdistance;
            }
            set
            {
                if (value > 0)
                {
                    longdistance = value;
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
            }
        }

        public Phone()
        {
            Console.WriteLine("Конструктор по умолчанию");
            count++;


        }

        public Phone(string name, string number)
        {
            Name = name;
            Number = Convert.ToInt32(number);
            Console.WriteLine($"{Name} с номером {Number}");
            count++;

        }

        public Phone(string name)
        {
            Name = name;
            Console.WriteLine($"модель телефона {Name}");
            count++;

        }

        static Phone()
        {

            Console.WriteLine("Вызвался статический конструктор");
            Console.WriteLine(ID.GetHashCode());
        }

        private Phone(int a)
        {

        }

        static public void Sum(ref int a, out int b)
        {
            b = a + a;
        }

        static public void Info()
        {
            Console.WriteLine($"Объектов создано {count}");
            
        }
        public void Credit(int x)
        {
            credit += x;
        }
        public void Balans()
        {
            if (credit > 0)
            {
                balance += credit;
                Console.WriteLine($"Ваш баланс {balance}");
            }
            else
            {
                Console.WriteLine($"Ваш баланс {balance}");
            }
        }
       
    }
}

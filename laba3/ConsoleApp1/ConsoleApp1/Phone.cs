using System;
namespace ConsoleApp1
{
    partial class Phone
    {
        static public readonly string ID = "qwe";
        public const string UNIVER = "BSTU";
        static public int count;
        private int number;
        private string Name;
        private string Adress { get; set; }
        
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if(Number > 0)
                {
                    number = value;
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
            }
        }
        private string TimeCity { get; set; }
        private string TimeLongDistance { get; set; }

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

            Console.WriteLine("Вызывлся статиический конструктор");
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
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int b = 123456;
            int a;
            int c = 0;

            while (b > 0)
            {
                a = b % 10;
                b /= 10;
                c = c * 10 + a;
            }
            Console.WriteLine(c);

            //1 только латинские
            //2 не меньше 8 символов и не более 30
            //3 хотя бы одна заглавная буква
            //4 хотя бы 1 цифра
            //5 без личных данных
            //6 без пробела
            //7 не могут содержать одни цифры или буквы
            //8 последовательная раскладка
            //9 слишком частое повторение
            //10 запрещены спецсимволы кроме(-_)
            //

        }
    }
}

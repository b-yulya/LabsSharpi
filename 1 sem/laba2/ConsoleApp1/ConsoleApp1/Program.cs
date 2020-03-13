
using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte pre1 = 1;
            byte pre2 = 2;
            short pre3 = 3;
            ushort pre4 = 4;
            int pre5 = 5;
            uint pre6 = 6;
            long pre7 = 7;
            ulong pre8 = 8;
            char pre9 = 'a';
            float pre10 = 10;
            double pre11 = 11;
            bool pre12 = true;
            decimal pre13 = 13;
            string pre14 = "keks";
            object pre15 = 15;
            dynamic pre16 = 16;
            // неявная приведение
            pre5 += pre4;
            pre11 += pre3;
            pre8 += pre4;
            pre6 += pre4;
            pre13 += pre2;
            // явное приведение
            pre7 += (long)pre8;
            pre3 = (short)pre6;
            pre15 = (object)pre16;
            pre11 = (double)pre13;
            pre1 = (sbyte)pre2;
            // upakovka
            object O = pre5;
            // raspakovka
            int j = (int)O;
            // 1-4
            var pre18 = 23;
            pre18 += pre2;
            // 1-5
            int? pre21 = null;
            int pre22 = pre21 ?? 100;

            int? pre23 = 12;
            int pre24 = pre23 ?? 14;
            // 2-1
            string st1 = "wow";
            string st2 = "wow";
            int lol;
            lol = String.Compare(st1, st2);
            Console.WriteLine("Сравнение строк:" + lol);
            // 2-2
            string st3 = "eeeeeeeeeeee";
            string st4 = "rrrrrrrrrrrr";
            string st5 = "wwwwwwwwwwww";
            Console.WriteLine("Сцепление:" + st3 + st4 + st5);
            string st6;
            st6 = String.Copy(st4);
            Console.WriteLine("Копирование:" + st6);
            string st7 = st6.Substring(6);
            Console.WriteLine("ПОдстрока:" + st7);
            string a = "This is a short string";
            Console.WriteLine("Строка:" + a);
            string[] words = a.Split(' ');
            foreach (string sv in words)
                Console.WriteLine(sv);
            Console.WriteLine("Вставки подстроки в заданную позицию:");

            Console.WriteLine("Строка:" + a);

            string subString = "!";
            a = a.Insert(8, subString);
            Console.WriteLine(a);
            Console.WriteLine("Удаление подстроки:");

            Console.WriteLine("Строка:" + a);
            a = a.Remove(5, 5);
            Console.WriteLine(a);
            // 2-3
            string s = "";
            string m = null;
            int tin = s.Length;
            Console.WriteLine("Длина пустой строки:" + tin);
            Console.WriteLine(" попытка вызвать метод для строки null вызовет исключение NullReferenceException. строки null можно использовать в операциях объединения и сравнения с другими строками");
            // Строка на основе  StringBuilder
            StringBuilder sb = new StringBuilder("Hello world", 40);
            sb.Append("!");
            sb.Insert(0, "!");
            sb.Remove(6, 4);
            Console.WriteLine(sb);
            // 3-1
            int[,] Array = new int[4, 4];
            Random ran = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Array[i, k] = ran.Next(1, 100);
                    Console.Write(Array[i, k] + "\t");
                }
                Console.WriteLine();
            }
            // 3-2
            string[] Arr = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday" };
            foreach (string str in Arr)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine($"Длина массива {Arr.Length}");
            Console.WriteLine("Введите элемент массива который хотите поменять");
            int vv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите новое значение");
            string ww = Console.ReadLine();
            Arr[vv - 1] = ww;
            foreach (string str in Arr)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();
            // 3-3
            float[][] arr3 = new float[3][];
            arr3[0] = new float[2];
            arr3[1] = new float[3];
            arr3[2] = new float[4];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < arr3[x].Length; y++)
                {
                    Console.WriteLine("Введите элемент массива: ");
                    arr3[x][y] = Convert.ToSingle(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < arr3[x].Length; y++)
                {
                    Console.Write(arr3[x][y] + "  ");

                }
                Console.Write("\n");
            }
            var Q = arr3;
            var QQ = a;
            // 4-1
            int tu1 = 1;
            string tu2 = "Andrey";
            char tu3 = 'G';
            string tu4 = "Igor";
            ulong tu5 = 9;
            var tuple1 = Tuple.Create<int, string, char, string, ulong>(tu1, tu2, tu3, tu4, tu5);
            var tuple2 = Tuple.Create<int, string, char, string, ulong>(tu1, tu2, tu3, tu4, tu5);
            // 4-2
            Console.WriteLine($"Кортеж {tuple1}");
            Console.WriteLine($"1 элемент кортежа {tuple1.Item1}");
            Console.WriteLine($"3 элемент кортежа {tuple1.Item3}");
            Console.WriteLine($"4 элемент кортежа {tuple1.Item4}");
            // 4-3
            string last = (string)tuple1.Item2;
            Console.WriteLine(last);
            // 4-4
            if (tuple1 == tuple2) { Console.WriteLine("\n Кортежи равны  \n"); }
            // 5 
            int[] bbb = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("MIN | MAX | SUM | FIRST");
            Console.WriteLine(fun(tu2, bbb));

        }
        static Tuple<int, int, int, char> fun(string a, int[] b)
        {
            int min = 100, max = 0, sum = 0; char h;
            foreach (int key in b)
            {
                if (key > max) { max = key; }
                if (key < min) { min = key; }
                sum += key;
            }
            h = a[0];
            var tuples = Tuple.Create<int, int, int, char>(min, max, sum, h);
            return tuples;
        }
    }
}

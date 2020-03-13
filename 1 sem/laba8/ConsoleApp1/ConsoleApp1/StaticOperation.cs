namespace ConsoleApp1
{
    static public class StaticOperation
    {
        static int count;
        static int sum;
        static int max;
        static int min = 99999;
        public static void Sum(Seet<int> Item)

        {
            foreach (int ch in Item.Items)
            {
                sum += ch;
            }
            System.Console.WriteLine($"Сумма элементов {sum}");
        }
        public static void Difference(Seet<int> Item)
        {

            foreach (int ch in Item.Items)
            {
                if (ch > max)
                {
                    max = ch;
                }
                if (ch < min)
                {
                    min = ch;
                }
            }
            int raz = max - min;
            System.Console.WriteLine($"Разница между максимальным и минимальным элементом {raz}");
        }
        public static void Count(Seet<int> Item)
        {
            foreach (int ch in Item.Items)
            {
                count++;
            }
            System.Console.WriteLine($"Количество элементов {count}");
        }
        public static void Sub(this string str) // Выделение первого числа, содержащего в строке
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    System.Console.WriteLine($"Первая цифра строки {str[i]}"); 
                    break;
                }
            }
        }
        public static void Plus(this Seet<int> item, Seet<int> item2) // Удаление положительных элементов из множества
        {
            for(int i=0;i<item.Items.Count; i++)
            {
                if(item.Items[i] <= 0)
                {
                    item2.Items.Add(item.Items[i]);
                }
            }
            System.Console.WriteLine("После удаление положительных элементов");
            for (int i = 0; i < item2.Items.Count; i++)
            {
                System.Console.Write(item2.Items[i] + " ");
            }

        }

    }

}

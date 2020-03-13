using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //////11111111
            Student Andrey = new Student();
            Random rand = new Random();
            ArrayList First = new ArrayList();
            First.Add(rand.Next(100));
            First.Add(rand.Next(100));
            First.Add(rand.Next(100));
            First.Add(rand.Next(100));
            First.Add(rand.Next(100));
            First.Add(Andrey);
            First.Remove(Andrey);

            foreach(int ch in First)
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine("Количество элементов в коллекции " + First.Count);
            if (First.Contains(84))
            {
                Console.WriteLine("Колекция содержит элемент : 84");
            }
            else
            {
                Console.WriteLine("Колекция не содержит элемент : 84");
            }

            ///////2222222

            SortedList<string, long> Second = new SortedList<string, long>();
            Second.Add("1 first", 1);
            Second.Add("2 second", 2);
            Second.Add("3 third", 3);
            Second.Add("4 fourth", 4);
            Second.Add("5 five", 5);
            Second.Add("6 six", 6);

            foreach (KeyValuePair<string, long> ch in Second)
            {
                Console.WriteLine($"Key : {ch.Key}, Value : {ch.Value}");
            }
            for(int i = 0; i < 3; i++)
            {
                Second.RemoveAt(i);
            }
            Console.WriteLine("После удаления элементов");
            foreach (KeyValuePair<string, long> ch in Second)
            {
                Console.WriteLine($"Key : {ch.Key}, Value : {ch.Value}");
            }

            IList<long> list = Second.Values;
            Stack<long> stak = new Stack<long>();
            for(int i = 0; i < list.Count; i++)
            {
                stak.Push(list[i]);
            }
            foreach(long ch in stak)
            {
                Console.WriteLine(ch);
            }
            if (stak.Contains(6))
            {
                Console.WriteLine(stak.Peek());
            }


            ///////3333333

            SortedList<int, Film> film = new SortedList<int, Film>();
            Film Titanik = new Film(25);
            Film SpanchBob = new Film(16);
            film.Add(1, Titanik);
            film.Add(2, SpanchBob);
            foreach(KeyValuePair<int, Film> ch in film)
            {
                Console.WriteLine(ch.Value);
            }

            IList<Film> spis = film.Values;
            Stack<Film> st = new Stack<Film>();
            for (int i = 0; i < spis.Count; i++)
            {
                st.Push(spis[i]);
            }
            foreach(Film ch in st)
            {
                Console.WriteLine(ch);
            }
            if (st.Contains(Titanik))
            {
                Console.WriteLine(st.Peek()); 
            }


            //////444444
            ///
            

            


            void ColectionChange(object sender, NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        Student newStud = e.NewItems[0] as Student;
                        Console.WriteLine($"Добавлен новый объект: {newStud.Name}");
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        Student OldStud = e.OldItems[0] as Student;
                        Console.WriteLine($"Удален объект: {OldStud.Name}");
                        break;

                }
            }


            ObservableCollection<Student> Stud = new ObservableCollection<Student>();
            Stud.CollectionChanged += ColectionChange;
            Stud.Add(new Student { Name = "Andrey" });
            Stud.Add(new Student { Name = "Igor" });
            Stud.Add(new Student { Name = "Kesha" });
            Stud.Add(new Student { Name = "Tanyusha" });
            foreach(Student stud in Stud)
            {
                Console.WriteLine(stud.Name);
            }



        }


        
    }
    class Student
    {
        public string Name { get; set; }
    }
    abstract class TVprogram
    {
        public int agelimit;
        public abstract void Watch();
    }

    class Film : TVprogram
    {

        




        static int limit = 16;
        public Film(int age)
        {
            agelimit = age;
        }
        public override void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Фильм начнется через 20 мин");
            }
            else
            {
                Console.WriteLine("Вам рано еще смотреть этот фильм");
            }
        }
        public override string ToString()
        {
            return $"Возрастное ограничение на просмотр этого фильма {agelimit}";
        }
    }
}

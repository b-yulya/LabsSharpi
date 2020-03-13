using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AgeLimitException : Exception
    {
        public AgeLimitException(string message) : base(message)
        {

        }
    }
    public class YearException : Exception
    {
        public YearException(string message) : base(message)
        {

        }
    }
    public class NullStringException : Exception
    {
        public NullStringException(string message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Producer Kail = new Producer();
            Person person = new Person();
            Person persona = Kail;
            if (person is Producer)
            {
                Producer Igor = (Producer)person;
            }
            else
            {
                Console.WriteLine("Преобразовать нельзя");
            }
            Producer Lip = person as Producer;
            if (Lip == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                Console.WriteLine("Преобразование удалось");
            }


            Kail.name = "Kail";

            Kail.Move();
            Console.WriteLine(Kail.ToString());
            Console.WriteLine(persona.name);
            Film Transformers = new Film(2005);
            Film Hello = new Film(2003);
            Transformers.time = 245;
            Cartoon Naruto = new Cartoon(6);
            News GC = new News(21);
            News LL = new News(18);
            Printer Print = new Printer();
            Transformers.Watch();
            Naruto.Watch();
            GC.Watch();
            ProgramGuide Hai = new ProgramGuide();
            Hai.Year = 2015;
            ProgramGuide Hai2 = new ProgramGuide();
            Hai.Year = 2003;
            ProgramGuide Hai3 = new ProgramGuide();
            Hai.Year = 2015;
            ProgramGuide Hai4 = new ProgramGuide(200);
            Hai.Year = 2007;



            List<object> array = new List<object>() { Kail, person, Naruto, GC, Transformers, Print };
            foreach (object ch in array)
            {
                Print.IAmPrinting(ch);
            }
            List<ProgramGuide> film = new List<ProgramGuide>() { Hai, Hai2, Hai3 };
            film.Add(Hai4);
            Controller.Count();
            Controller.Search(film);
            Hai4.Inf();
            
            // 7 Laba

            try
            {
                User Andrey = new User("Andrey", 19);
                Film Hello1 = new Film(2003);
                Film Hello2 = new Film(-200); // error1
                int a = 0;
                int b = 100 / a; // eror2
                string[] kre = new string[5];
                kre[5] = "dfr"; // error3
                News QWE = new News(2888); // error4
                User Igor = new User("", -30);
                Igor.Info(); // error5

                int? pointer = null;
                Assert(pointer != null, "переменная равна -- null");
            }
            catch (NullStringException e)
            {
                Console.WriteLine(e);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (YearException e)
            {
                Console.WriteLine(e);
            }
            catch (AgeLimitException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Проверка завершена!");
            }
        }

        private static void Assert(bool v1, string v2)
        {
            throw new NotImplementedException();
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer Olya = new Producer();
            Producer Kail = new Producer();
            Person person = new Person();
            Person persona = Kail;
            Producer Olu = (Producer)person;
           
            if (person is Producer)
            {
                Producer Igor = (Producer)person;
            }
            else{
                Console.WriteLine("Преобразовать нельзя");
            }
            Producer Lip = person as Producer;
            if(Lip == null)
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
            Film Transformers = new Film(15);
            Cartoon Naruto = new Cartoon(6);
            News GC = new News(21);
            Printer Print = new Printer();
            Transformers.Watch();
            Naruto.Watch();
            GC.Watch();
            List<object> array = new List<object>() { Kail, person, Naruto, GC, Transformers, Print };
            foreach(object ch in array)
            {
                Print.IAmPrinting(ch);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Russia("Петя"));
            people.Add(new English("Paul"));
            people.Add(new Germany("Hans"));

            foreach (Person person in people)
            {
                person.SayHello();
            }

            Console.ReadKey(true);
        }
    }
}

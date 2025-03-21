using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PrintedMatter> printedMatters = new List<PrintedMatter>(4);
            printedMatters.Add(new Magazine("Журнал", 100, 5.25));
            printedMatters.Add(new Newspaper("Газета", 2500, 4, 0.3));

            foreach(var matter in printedMatters)
            {
                matter.Print();
                Console.WriteLine($"Стоимость тиража: {matter.CirculationCost()}");
            }

            Console.ReadKey(true);
        }
    }
}

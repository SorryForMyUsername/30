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
            List<PrintedMatter> printedMatters = new List<PrintedMatter>();
            printedMatters.Add(Magazine.Input());
            printedMatters.Add(Magazine.Input());
            printedMatters.Add(Newspaper.Input());
            Console.WriteLine();

            foreach(var matter in printedMatters)
            {
                matter.Print();
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}

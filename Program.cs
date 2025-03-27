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
            List<PrintedMatter> pressa = new List<PrintedMatter>();
            bool flag = true;
            do
            {
                Console.Write("Введите название печатной продукции: ");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "m":
                    case "M":
                        pressa.Add(Magazine.Enter());
                        break;
                    case "n":
                    case "N":
                        pressa.Add(Newspaper.Enter());
                        break;
                    case "e":case "E":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Нет такой печатной продукции");
                        break;
                }
                foreach (PrintedMatter p in pressa)
                {
                    p.Print();
                    Console.WriteLine("Стоимость тиража: " + p.CirculationCost() + " руб.\n");
                }
            } while (flag);

            Console.ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method1();
            derivedClass.Method2();
            derivedClass.Method3();
            derivedClass.Method4();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_30
{
    internal class DerivedClass : AClass
    {
        /// <summary>
        /// Переопределённый виртуальный метод с именем Method2.
        /// </summary>
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Метод с именем Method2 из класса AClass " +
                "реализованный в производном классе DerivedClass");
        }

        /// <summary>
        /// Переопределённый абстрактный метод с именем Method3.
        /// </summary>
        public override void Method3()
        {
            Console.WriteLine("Метод с именем Method3 из класса AClass " +
                "реализовованный в производном классе DerivedClass");
        }

        /// <summary>
        /// Переопределённый абстрактный метод с именем Method4.
        /// </summary>
        public override void Method4()
        {
            Console.WriteLine("Метод с именем Method4 из класса AClass " +
                "реализовованный в производном классе DerivedClass");
        }
    }
}

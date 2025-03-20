using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_30
{
    /// <summary>
    /// Абстрактный класс
    /// </summary>
    internal abstract class AClass
    {
        /// <summary>
        /// Обычный метод с именем Method1.
        /// </summary>
        public void Method1() =>
            Console.WriteLine("Это обычный метод с именем Method1 из " +
                "абстрактного класса с именем AClass");

        /// <summary>
        /// Виртуальный метод с именем Method2.
        /// </summary>
        public virtual void Method2() =>
            Console.WriteLine("Виртуальный метод с именем Method2 " +
                "из абстрактного класса с именем AClass");

        /// <summary>
        /// Абстрактный метод с именем Method3.
        /// </summary>
        public abstract void Method3();

        /// <summary>
        /// Абстрактный метод с именем Method4.
        /// </summary>
        public abstract void Method4();
    }
}

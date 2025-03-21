using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_2
{
    /// <summary>
    /// Печатная продукция
    /// </summary>
    internal abstract class PrintedMatter
    {
        /// <summary>
        /// Поле Название
        /// </summary>
        private string name;

        /// <summary>
        /// Свойство Название
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    name = "Неизвестно";
                }
                else name = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public PrintedMatter() { }

        /// <summary>
        /// Конструктор с одним параметром.
        /// </summary>
        /// <param name="name">Название</param>
        public PrintedMatter(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Абстрактный метод для вычисления стоимости тиража.
        /// </summary>
        /// <returns></returns>
        public abstract double CirculationCost();

        /// <summary>
        /// Абстрактный метод для вывода информации о печатной продукции.
        /// </summary>
        public abstract void Print();
    }
}

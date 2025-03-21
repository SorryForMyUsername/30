using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_2
{
    /// <summary>
    /// Журнал
    /// </summary>
    internal class Magazine : PrintedMatter
    {
        /// <summary>
        /// Поле Тираж
        /// </summary>
        private int circulation;
        /// <summary>
        /// Поле Цена
        /// </summary>
        private double price;

        /// <summary>
        /// Свойство Тираж
        /// </summary>
        public int Circulation { get => circulation; set => circulation = value; }
        /// <summary>
        /// Свойство Цена
        /// </summary>
        public double Price { get => price; set => price = value; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Magazine() { }

        /// <summary>
        /// Конструктор с тремя параметрами.
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="cirlulation">Тираж</param>
        /// <param name="price">Цена</param>
        public Magazine(string name, int cirlulation, double price) : base(name) 
        {
            Circulation = cirlulation;
            Price = price;
        }

        /// <summary>
        /// Переопределённый метод для вычисления стоимости тиража
        /// </summary>
        /// <returns></returns>
        public override double CirculationCost()
        {
            return Circulation * Price;
        }

        /// <summary>
        /// Переопределённый метод для вывода информации о журнале.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Название: {Name}\tТираж: {circulation}\t" +
                $"Цена: {Price}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_2
{
    /// <summary>
    /// Газета
    /// </summary>
    internal class Newspaper : PrintedMatter
    {
        /// <summary>
        /// поле Тираж
        /// </summary>
        private int circulation;
        /// <summary>
        /// поле Количество листов
        /// </summary>
        private int sheets;
        /// <summary>
        /// поле Стоимость листа
        /// </summary>
        private double sheetPrice;

        /// <summary>
        /// Свойство Тираж
        /// </summary>
        public int Circulation
        {
            get { return circulation; }
            set
            {
                if (value < 0) circulation = 0;
                else circulation = value;
            }
        }
        /// <summary>
        /// Свойство Количество листов
        /// </summary>
        public int Sheets
        {
            get { return sheets; }
            set
            {
                if (value < 0) sheets = 0;
                else sheets = value;
            }
        }
        /// <summary>
        /// Свойство Стоимость листа
        /// </summary>
        public double SheetPrice
        {
            get { return sheetPrice; }
            set
            {
                if(value < 0) sheetPrice = 0;
                else sheetPrice = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Newspaper() { }

        /// <summary>
        /// Конструктор с четырьмя параметрами.
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="cirlulation">Тираж</param>
        /// <param name="sheets">Количество листов</param>
        /// <param name="sheetPrice">Стоимость листа</param>
        public Newspaper(string name, int cirlulation, int sheets, double sheetPrice) : base(name)
        {
            Circulation = cirlulation;
            Sheets = sheets;
            SheetPrice = sheetPrice;
        }

        /// <summary>
        /// Переопределённый метод для вычисления стоимости тиража.
        /// </summary>
        /// <returns></returns>
        public override double CirculationCost()
        {
            return Circulation * sheetPrice * sheets;
        }

        /// <summary>
        /// Переопределённый метод для вывода информации о газете.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Название: {Name}\tТираж: {circulation}\t" +
                $"Кол-во листов: {Sheets}\tСтоимость листа: {SheetPrice}");
        }
    }
}

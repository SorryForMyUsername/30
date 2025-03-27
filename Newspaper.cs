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
        private int sheetsCount;
        /// <summary>
        /// поле Стоимость листа
        /// </summary>
        private double sheetCost;

        /// <summary>
        /// Свойство Тираж
        /// </summary>
        public int Circulation
        {
            get { return circulation; }
            set
            {
                if (value < 0) Console.WriteLine("Недопустимое значение!");
                else circulation = value;
            }
        }
        /// <summary>
        /// Свойство Количество листов
        /// </summary>
        public int SheetsCount
        {
            get { return sheetsCount; }
            set
            {
                if (value < 0) Console.WriteLine("Недопустимое значение!");
                else sheetsCount = value;
            }
        }
        /// <summary>
        /// Свойство Стоимость листа
        /// </summary>
        public double SheetCost
        {
            get { return sheetCost; }
            set
            {
                if(value < 0) sheetCost = 0.0;
                else sheetCost = value;
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
        /// <param name="sheetCost">Стоимость листа</param>
        public Newspaper(string name, int cirlulation, int sheets, double sheetCost) : base(name)
        {
            Circulation = cirlulation;
            SheetsCount = sheets;
            SheetCost = sheetCost;
        }

        /// <summary>
        /// Переопределённый метод для вычисления стоимости тиража.
        /// </summary>
        /// <returns></returns>
        public override double CirculationCost()
        {
            return Circulation * SheetCost * SheetsCount;
        }

        /// <summary>
        /// Переопределённый метод для вывода информации о газете.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Печатная продукция - газета {Name}\n" +
                $"Количество листов - {SheetsCount}\tСтоимость 1-го листа - {SheetCost} руб.\t" +
                $"Тираж газеты составляет {Circulation} экз.");
        }

        public static Newspaper Enter()
        {
            Console.Clear();
            Console.WriteLine("Создание новой газеты.");
            Console.Write("Название: ");
            string name = Console.ReadLine();
            Console.Write("Тираж: ");
            int circulation = int.Parse(Console.ReadLine());
            Console.Write("Кол-во листов: ");
            int sheets = int.Parse(Console.ReadLine());
            Console.Write("Стоимость листа: ");
            double sheetPrice = double.Parse(Console.ReadLine());
            Console.WriteLine();
            return new Newspaper(name, circulation, sheets, sheetPrice);
        }
    }
}

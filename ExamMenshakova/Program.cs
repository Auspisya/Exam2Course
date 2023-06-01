using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMenshakova
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2; // Количество фигур в массиве
            Figure[] figures = new Figure[n]; // Создание массива фигур

            // Инициализация фигур в массиве
            figures[0] = new Triangle(3.0, 4.0, 5.0);
            figures[1] = new Circle(2.0);

            // Вывод полной информации о фигурах на экран
            foreach (Figure figure in figures)
            {
                figure.PrintInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

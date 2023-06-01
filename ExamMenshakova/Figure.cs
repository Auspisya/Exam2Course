using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMenshakova
{
    abstract class Figure
    {
        public abstract double GetArea(); // Метод для вычисления площади
        public abstract double GetPerimeter(); // Метод для вычисления периметра
        public virtual void PrintInfo() // Метод для вывода информации о фигуре на экран
        {
            Console.WriteLine($"Фигура: {this.GetType().Name}");
            Console.WriteLine($"Площадь: {GetArea():F}");
            Console.WriteLine($"Периметр: {GetPerimeter():F}");
        }
    }
}

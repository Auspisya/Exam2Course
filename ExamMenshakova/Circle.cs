using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMenshakova
{
    class Circle : Figure
    {
        private double r; // Радиус окружности

        public Circle(double r)
        {
            this.r = r;
        }

        public override double GetArea() // Вычисление площади окружности
        {
            if (r > 0) { return Math.PI * r * r; } else { return 0; }
        }

        public override double GetPerimeter() // Вычисление периметра окружности
        {
            if (r > 0) { return 2 * Math.PI * r; } else { return 0; }
        }

        public override void PrintInfo() // Вывод полной информации об окружности
        {
            if (GetArea() > 0 && GetPerimeter() > 0)
                { Console.WriteLine($"Окружность. Радиус: {r}. Площадь: {GetArea()}. Периметр: {GetPerimeter()}."); }
            else 
                { Console.WriteLine("Радиус окружности не может быть отрицательным или равным нулю!"); }
        }
    }
}

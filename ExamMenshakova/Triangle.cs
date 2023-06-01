using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMenshakova
{
    class Triangle : Figure
    {
        // Стороны треугольника
        private double a;
        private double b;
        private double c; 

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea() // Вычисление площади для теругольника
        {
            if (a > 0 && b > 0 && c > 0)
                {
                    double p = (a + b + c) / 2.0;
                    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
            else { return 0; }
        }

        public override double GetPerimeter() // Вычисление периметра для треугольника
        {
            if (a > 0 && b > 0 && c > 0) { return a + b + c; } 
            else { return 0; }
        }

        public override void PrintInfo() // Вывод полной информации о треугольнике 
        {
            if (GetArea() > 0 && GetPerimeter() > 0)
                { Console.WriteLine($"Треугольник. Стороны: {a}, {b}, {c}. Площадь: {GetArea()}. Периметр: {GetPerimeter()}."); }
            else 
                { Console.WriteLine("Стороны треугольника не могут быть отрицательными или равными нулю!"); }
            
        }
    }
}

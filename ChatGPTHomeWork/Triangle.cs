using System;
using System.Linq.Expressions;
using ChatGPTHomeWork;

namespace ChatGPTHomeWork
{
    internal class Triangle : IFigure
    {
        string name { get; }
        double sideA { get; }
        double sideB { get; }
        double sideC { get; }

        double area { get; set; }
        public Triangle(string name, double sideA, double sideB, double sideC)
        {
            this.name = name;
            this.sideA = verification(sideA); 
            this.sideB = verification(sideB); 
            this.sideC = verification(sideC); 

        }
        public void CalculateArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            this.area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public void PrintDetails()
        {
            if (area > 0)
            {
                Console.WriteLine($"Name:{name}\nSides:A={sideA},B={sideB},C={sideC}\nArea:{area}");
            }
            else
            {
                Console.WriteLine($"Name:{name}\nSides:A={sideA},B={sideB},C={sideC}\nSuch a triangle doesn't exist");
            }
        }
        private double verification(double number)
        {
            if (number < 1)
            {
                while (number < 1)
                {
                    Console.WriteLine($"некорректное значение стороны {name}\nВведите число больше единицы");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out number)) ;
                }
            }

            return number;
        }

    }


}

using System;

namespace ChatGPTHomeWork
{
    internal class Square : IFigure
    {
        string name {  get;}
        double side { get;}
        double area { get; set;}
        public Square(string name,double side) 
        {
            this.name = name;
            this.side = verification(side);
        
        }
        public void CalculateArea()
        {
            this.area = Math.Pow(side,2);
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name:{name}\nSide:{side}\nArea:{area}");
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

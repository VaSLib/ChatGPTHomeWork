using System;

namespace ChatGPTHomeWork
{
    internal class Circle : IFigure
    {
        string name { get;}

        double radius {  get;}
        
        double area { get; set; }

        internal Circle (string name,double radius)
        { 
            this.name = name;
            this.radius =  verification(radius);
            
        }


        public void CalculateArea()
            
        {
           this.area=Math.PI* Math.Pow(radius, 2);
            
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Figure:{name}\nRadius:{radius}\nArea:{area}");
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

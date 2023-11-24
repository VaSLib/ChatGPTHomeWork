using System;
using System.Xml.Linq;
using ChatGPTHomeWork;

namespace ChatGPTHomeWork
{
    internal class Output
    {
        public void Menu()
        {
            PrintConsole printConsole1 = new PrintConsole();
            ConsoleKeyInfo keyInfo;
            int number = 0;
            string[] menuItems = { "Add figure", "Remove figure", "Look at the figures","sdasdfsadfa","ASDFafAS" };

            do
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("      MENU      \n");
                Console.BackgroundColor = ConsoleColor.Black;

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == number)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(menuItems[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + menuItems.Length) % menuItems.Length; }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % menuItems.Length; }

                if (keyInfo.Key == ConsoleKey.Enter && number == 0) { AddFigure(); }
                if (keyInfo.Key == ConsoleKey.Enter && number == 1) { RemoveFigure(); }
                if (keyInfo.Key == ConsoleKey.Enter && number == 2) { LookFigures(); }

            } while (keyInfo.Key != ConsoleKey.Escape);

            void RemoveFigure()
            {
                int numList = 0;
                do
                {
                    Console.Clear();
                    printConsole1.Print();
                    for (int i = 0; i < printConsole1.figureList.Count; i++)
                    {


                        if (i == numList)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        printConsole1.figureList[i].PrintDetails();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                    }


                    if (numList == printConsole1.figureList.Count)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Back");
                        Console.BackgroundColor = ConsoleColor.Black;

                    }
                    else
                    {
                        Console.WriteLine("Back");

                    }


                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.UpArrow) { numList = (numList - 1 + (printConsole1.figureList.Count + 1)) % (printConsole1.figureList.Count + 1); }
                    if (keyInfo.Key == ConsoleKey.DownArrow) { numList = (numList + 1) % (printConsole1.figureList.Count + 1); }

                    if (keyInfo.Key == ConsoleKey.Enter && numList == printConsole1.figureList.Count) { return; }
                    if (keyInfo.Key == ConsoleKey.Enter) { printConsole1.RemoveFigure(numList); }


                } while (keyInfo.Key != ConsoleKey.Escape);
            }
            void LookFigures()
            {
                int numList = 0;
                do
                {
                    Console.Clear();
                    printConsole1.Print();
                    for (int i = 0; i < printConsole1.figureList.Count; i++)
                    {


                        if (i == numList)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        printConsole1.figureList[i].PrintDetails();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                    }
                    if (numList == printConsole1.figureList.Count)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Back");
                        Console.BackgroundColor = ConsoleColor.Black;

                    }
                    else
                    {
                        Console.WriteLine("Back");

                    }



                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.UpArrow) { numList = (numList - 1 + (printConsole1.figureList.Count + 1)) % (printConsole1.figureList.Count + 1); }
                    if (keyInfo.Key == ConsoleKey.DownArrow) { numList = (numList + 1) % (printConsole1.figureList.Count + 1); }

                    if (keyInfo.Key == ConsoleKey.Enter && numList == printConsole1.figureList.Count) { return; }


                } while (keyInfo.Key != ConsoleKey.Escape);

            }


            void AddFigure()
            {
                int figNum = 0;
                string[] figureItems = { "Circle", "Square", "Triangle", "Back" };
                do
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("What kind of figure you want to add\n");
                    Console.BackgroundColor = ConsoleColor.Black;

                    for (int i = 0; i < figureItems.Length; i++)
                    {
                        if (i == figNum)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine(figureItems[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }


                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.UpArrow) { figNum = (figNum - 1 + figureItems.Length) % figureItems.Length; }
                    if (keyInfo.Key == ConsoleKey.DownArrow) { figNum = (figNum + 1) % figureItems.Length; }



                    if (keyInfo.Key == ConsoleKey.Enter && figNum == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter radius:");
                        double radius = verification(Console.ReadLine(), "Radius");
                        Circle circle = new Circle("CIRCLE", radius);
                        printConsole1.AddFigure(circle);
                    }
                    if (keyInfo.Key == ConsoleKey.Enter && figNum == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter side:");
                        double side = verification(Console.ReadLine(), "Side");
                        Square square = new Square("SQUARE", side);
                        printConsole1.AddFigure(square);

                    }
                    if (keyInfo.Key == ConsoleKey.Enter && figNum == 2)
                    {

                        Console.Clear();
                        Console.WriteLine("Enter Side-A:");
                        double sideA = verification(Console.ReadLine(),"A");

                        Console.WriteLine("Enter Side-B:");
                        double sideB = verification(Console.ReadLine(), "B");

                        Console.WriteLine("Enter Side-C:");
                        double sideC = verification(Console.ReadLine(), "C");

                        Triangle triangle = new Triangle("TRIANGLE", sideA, sideB, sideC);
                        printConsole1.AddFigure(triangle);

                    }
                    if (keyInfo.Key == ConsoleKey.Enter && figNum == 3) { return; }

                } while (keyInfo.Key != ConsoleKey.Escape);
            }

            double verification(string numIn,string name)
            {
                double number;
                 while (double.TryParse(numIn,out number)!=true)
                {
                    Console.WriteLine("цифру пиши");
                    numIn =Console.ReadLine();
                }

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
}

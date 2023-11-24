using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTHomeWork
{
    internal class PrintConsole
    {
        public List<IFigure> figureList=new List<IFigure>();

       


        

        public List<IFigure> GetFigure()
        {
            return figureList;
        }
        public void Print()
        {
            foreach (IFigure figure in figureList)
            {
                figure.CalculateArea();
            }
        }

        public void AddFigure(IFigure item)
        {
            figureList.Add(item);
        }
        public void RemoveFigure(int item) 
        {
        figureList.RemoveAt(item);
        }


    }
}

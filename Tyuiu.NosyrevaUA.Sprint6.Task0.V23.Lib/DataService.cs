using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NosyrevaUA.Sprint6.Task0.V23.Lib
{
    public class DataService : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double y1 = ((double)(x + 1)) / ((double)(x + 2));
            double y = Math.Log(y1);
            return Math.Round(y,3);
        }
    }
}

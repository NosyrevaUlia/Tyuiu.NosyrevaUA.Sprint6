using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NosyrevaUA.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin((double)x) - 2 == 0)
                {
                    y = 0;
                    valueArray[c] = y;
                    c++;
                }
                else
                {
                    y = Math.Round((5 * (double)x + 2.5) / (Math.Sin((double)x) - 2) + 2, 2);
                    valueArray[c] = y;
                    c++;
                }
            }
            return valueArray;
        }
    }
}

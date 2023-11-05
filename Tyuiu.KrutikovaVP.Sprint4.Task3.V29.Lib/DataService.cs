using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KrutikovaVP.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0)+1;
            int columns = array.Length / rows;

            int mult = 1;
            for (int i =0; i<rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j==0)
                    {
                        mult *= array[i, j];
                    }

                }
            }
            return mult;
        }
    }
}

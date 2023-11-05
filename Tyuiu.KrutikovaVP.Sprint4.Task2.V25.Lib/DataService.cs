using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KrutikovaVP.Sprint4.Task2.V25.Lib
{
    public class DataService : ISprint4Task2V25
    {
        public int Calculate(int[] array)
        {
            int numsMultArrEl = 1;
            for (int i =0; i<=array.Length-1; i++)
            {
                if (array[i]%2==0)
                numsMultArrEl *= array[i];
            }
            return numsMultArrEl;
        }
    }
}

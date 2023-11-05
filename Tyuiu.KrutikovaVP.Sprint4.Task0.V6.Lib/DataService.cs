﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KrutikovaVP.Sprint4.Task0.V6.Lib
{
    public class DataService : ISprint4Task0V6
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sumOddArrEl = 0;
            for (int i = 0; i<=array.Length-1; i++)
            {
                if (array[i]%2!=0)
                {
                    sumOddArrEl += array[i];
                }
            }
            return sumOddArrEl;
        }
    }
}

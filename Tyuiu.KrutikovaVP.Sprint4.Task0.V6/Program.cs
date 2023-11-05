using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint4.Task0.V6.Lib;

namespace Tyuiu.KrutikovaVP.Sprint4.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                        *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                      *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9, подсчитать    *");
            Console.WriteLine("* сумму нечетных элементов массива.{1 ,6 ,3 ,7 ,5 ,4 ,2 ,7 ,8 ,9}          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int[] numsArray = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i<=numsArray.Length-1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Сумма нечетных элементов массива = {ds.GetSumOddArrEl(numsArray)}");
            Console.ReadKey();
        }
    }
}

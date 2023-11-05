using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint4.Task1.V2.Lib;

namespace Tyuiu.KrutikovaVP.Sprint4.Task1.V2
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
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов                      *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 7, подсчитать    *");
            Console.WriteLine("* сумму нечетных элементов массива.  С клавиатуры:                         *");
            Console.WriteLine("* {1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2}                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int[] numsArray = new int[14];

            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                if (numsArray[i]>7 || numsArray[i]<1)
                Console.Write($"Введите значение {i} элемент массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i =0; i<=numsArray.Length-1; i++)
            {
                Console.Write(numsArray[i]+"\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Сумма нечетных элементов массива = {ds.Calculate(numsArray)}");
            Console.ReadKey();
        }
    }
}

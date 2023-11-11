using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrutikovaVP.Sprint4.Task7.V23.Lib;

namespace Tyuiu.KrutikovaVP.Sprint4.Task7.V23
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
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"678135972584\". Преобразуйте её      *");
            Console.WriteLine("* в матрицу 4 на 3 и подсчитайте количество четных чисел.                  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int rows = 4;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "678135972584";

            int index = 0;
            Console.WriteLine("\nМассив: ");
            for(int i =0; i<rows; i++)
            {
                for(int j = 0; j<columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            
            Console.WriteLine($"Количество четных элементов массива = {ds.Calculate(rows, columns, str)} ");
            Console.ReadKey();
        }
    }
}

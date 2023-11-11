using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint4.Task6.V2.Lib;

namespace Tyuiu.KrutikovaVP.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var mas2 = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] res = ds.Calculate(mas2);
            string[] wait = { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

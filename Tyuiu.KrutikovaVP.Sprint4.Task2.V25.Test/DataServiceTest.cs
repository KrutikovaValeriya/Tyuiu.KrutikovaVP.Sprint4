using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint4.Task2.V25.Lib;

namespace Tyuiu.KrutikovaVP.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 3, 4, 8, 7, 5, 9, 6, 7, 7, 5, 8 };
            int res = ds.Calculate(numsArray);
            int wait = 1536;
            Assert.AreEqual(wait, res);
        }
    }
}

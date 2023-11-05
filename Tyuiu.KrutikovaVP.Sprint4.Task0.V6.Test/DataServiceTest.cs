using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint4.Task0.V6.Lib;

namespace Tyuiu.KrutikovaVP.Sprint4.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = ds.GetSumOddArrEl(array);
            int waitSumOddArrEl = 32;
            Assert.AreEqual(waitSumOddArrEl, res);
        }
    }
}

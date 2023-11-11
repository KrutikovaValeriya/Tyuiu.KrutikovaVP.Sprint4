using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KrutikovaVP.Sprint4.Task5.V7.Lib;

namespace Tyuiu.KrutikovaVP.Sprint4.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas2 =new int[5,5] { { -1,5,-6,-2,7 },
                                        { 0,6,4,-1,-3 },
                                        { 3,3,0,-3,-2},
                                        { 7,-7,-7,5,0},
                                        { 6,-6,-4,2,0} };
            int wait = 11;
            int res = ds.Calculate(mas2);
            Assert.AreEqual(wait, res);
        }
    }
}

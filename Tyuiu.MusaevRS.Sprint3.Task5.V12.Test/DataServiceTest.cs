using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint3.Task5.V12.Lib;

namespace Tyuiu.MusaevRS.Sprint3.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 69.686;
            double res = ds.GetSumSumSeries(5, 1, 1, 4, 9);
            Assert.AreEqual(wait, res);

        }
    }
}

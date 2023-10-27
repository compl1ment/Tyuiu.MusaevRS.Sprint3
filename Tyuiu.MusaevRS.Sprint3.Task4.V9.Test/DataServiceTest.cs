using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint3.Task4.V9.Lib;

namespace Tyuiu.MusaevRS.Sprint3.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -3;
            int stopValue = 4;
            double wait = -30.877;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}

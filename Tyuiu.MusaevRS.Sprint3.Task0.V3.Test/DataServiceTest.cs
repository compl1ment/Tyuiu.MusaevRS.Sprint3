using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint3.Task0.V3.Lib;

namespace Tyuiu.MusaevRS.Sprint3.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 1;

            double wait = 1;
            double res = ds.GetMultiplySeries(value, startValue, stopValue;

            Assert.AreEqual(wait, res);
        }
    }
}

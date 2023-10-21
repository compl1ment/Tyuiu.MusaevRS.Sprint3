using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint3.Task2.V16.Lib;
namespace Tyuiu.MusaevRS.Sprint3.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 36;
            int value = 2;
            int startvalue = 1;
            int stopvalue = 3;
            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);
            Assert.AreEqual(wait, res);
        }
    }
}

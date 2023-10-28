using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint3.Task7.V6.Lib;

namespace Tyuiu.MusaevRS.Sprint3.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -3;
            int stopValue = 2;

            int len = (stopValue - startValue) + 1;

            double[] waitValue;
            waitValue = new double[len];

            waitValue[0] = 13.10;
            waitValue[1] = 7.24;
            waitValue[2] = 1.80;
            waitValue[3] = -8.00;
            waitValue[4] = -5.70;
            waitValue[5] = -11.26;

            double[] res;
            res = new double[len];

            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(waitValue, res);



        }
    }
}

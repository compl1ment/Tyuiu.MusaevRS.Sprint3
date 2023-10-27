using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint3.Task6.V3.Lib;

namespace Tyuiu.MusaevRS.Sprint3.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 60;
            int res = ds.GetSumTheDivisors(10, 14);
            Assert.AreEqual(wait, res);
        }
    }
}

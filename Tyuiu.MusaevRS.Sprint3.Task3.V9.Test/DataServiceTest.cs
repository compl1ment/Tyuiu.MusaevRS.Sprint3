using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint3.Task3.V9.Lib;

namespace Tyuiu.MusaevRS.Sprint3.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataSerivce ds = new DataSerivce();
            string value = "56hy vfe4r4 vf45b";
            char item = 'w';
            string wait = "wwhy vfewrw vfwwb";
            string res = ds.ReplaceNumOnChar(value, 'w');
            Assert.AreEqual(wait, res);
        }
    }
}

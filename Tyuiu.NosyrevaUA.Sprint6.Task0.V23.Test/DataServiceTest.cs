using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NosyrevaUA.Sprint6.Task0.V23.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double w = -0.223;
            Assert.AreEqual(res, w);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint6.Task2.V13.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedGetMassFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] w = {3.30, -12.37, -14.02, -5.57, 0.65, 0, -0.65, 5.57, 14.02, 12.37, -3.30 };
            CollectionAssert.AreEqual(res, w);
        }
    }
}

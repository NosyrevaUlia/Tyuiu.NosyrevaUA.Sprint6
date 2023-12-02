using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint6.Task1.V1.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedGetMassFunction()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { -11.22, -8.65, -4.76, -6.47, -2.98, 1.00, 1.82, 3.55, 6.99, 7.74, 9.03 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}

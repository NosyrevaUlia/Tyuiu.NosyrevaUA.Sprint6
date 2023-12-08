using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint6.Task4.V19.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            
            double[] res = ds.GetMassFunction(start,stop);
            double[] w = { 23.61, 16.08, 7.84, 4.58, 2.88, 0.75, -4.47, -9.46, -7.41, -6.16, -7.29 };
            CollectionAssert.AreEqual(w, res);
        }
    }
}

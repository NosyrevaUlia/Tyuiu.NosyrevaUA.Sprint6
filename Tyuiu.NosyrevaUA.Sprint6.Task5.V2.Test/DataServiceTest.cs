using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint6.Task5.V2.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Юлия\source\repos\Tyuiu.NosyrevaUA.Sprint6\Tyuiu.NosyrevaUA.Sprint6.Task5.V2\bin\Debug\InPutFileTask5V2.txt";
            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);
            double[] w = { -1, -2, -3, -5, -6, -7, -8, -9, -10 };
            CollectionAssert.AreEqual(w, res);
        }
    }
}

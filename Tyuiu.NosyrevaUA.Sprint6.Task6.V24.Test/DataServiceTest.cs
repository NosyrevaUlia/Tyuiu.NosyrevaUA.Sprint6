using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint6.Task6.V24.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Юлия\source\repos\Tyuiu.NosyrevaUA.Sprint6\InPutFileTask6V24.txt";
            string res = ds.CollectTextFromFile(path);
            string w = "EovFJVudRgdWKwQBrOMEwyq";
           
            Assert.AreEqual(w, res);
        }
    }
}

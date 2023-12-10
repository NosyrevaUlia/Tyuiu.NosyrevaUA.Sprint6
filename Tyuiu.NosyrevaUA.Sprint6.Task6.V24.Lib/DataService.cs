using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NosyrevaUA.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
        public int len = 0;
        public string CollectTextFromFile(string path)
        {
            
            string strRes = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadToEnd().Replace("\n", ";");
                string[] linesop = line.Split(';');

                for(int i = 0; i < linesop.Length; i++)
                {
                    string[] linessec = linesop[i].Split();
                    strRes += linessec[0];
                }
                
            }
            return strRes;
        }
    }
}

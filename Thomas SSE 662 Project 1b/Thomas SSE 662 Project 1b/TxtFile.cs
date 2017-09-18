using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Thomas_SSE_662_Project_1b
{
    public class TxtFile
    {
        public void writeFile(string fileLoc, string txt)
        {
            string[] lines = txt.Split(',');
            System.IO.File.WriteAllLines(fileLoc, lines);
        }
        public string readFile(string fileLoc)
        {
            string returnValue = "";
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\test.txt");
            for(int i = 0; i < lines.Count(); i++)
            {
                returnValue = returnValue + ", " + lines[i];
            }
            return "";
        }
    }
}

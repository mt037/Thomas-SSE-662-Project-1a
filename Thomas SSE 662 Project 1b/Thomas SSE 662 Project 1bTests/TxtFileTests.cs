using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thomas_SSE_662_Project_1b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Thomas_SSE_662_Project_1b.Tests
{
    [TestClass()]
    public class TxtFileTests
    {
        [TestMethod()]
        public void writeFileTest()
        {
            string[] testValuesLocation = { null, "empty", "bla.bla", "C:\\Users\\Public\\Documents\\test.txt", "C:\\Users\\Public\\Documents\\DoesntExist.txt" };
            string[] testValues = { null, "this is a test", "", "nope", "hi, hello, wow"};
            TxtFile file = new TxtFile();
            for (int i = 0; i < testValues.Length; i++)
            {
                try
                {
                    file.writeFile(testValuesLocation[i], testValues[i]);
                }
                catch
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod()]
        public void readFileTest()
        {
            string[] testValues = { null, "empty", "bla.bla", "C:\\Users\\Public\\Documents\\test.txt", "C:\\Users\\Public\\Documents\\DoesntExist.txt" };
            TxtFile file = new TxtFile();
            for (int i = 0; i < testValues.Length; i++)
            {
                try
                {
                    file.readFile(testValues[i]);
                }
                catch
                {
                    Assert.Fail();
                }
            }
        }

    }
}
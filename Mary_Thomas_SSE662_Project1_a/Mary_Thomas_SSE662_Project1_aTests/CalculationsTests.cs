using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mary_Thomas_SSE662_Project1_a;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mary_Thomas_SSE662_Project1_a.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void getCosTest()
        {
            string[] testValues = { "-180", "a", "30", null};
            double result = 0;
            for (int i = 0; i < testValues.Length; i++)
            {
                try
                {
                   result = Calculations.getCos(testValues[i]);
                }
                catch
                {
                    Assert.Fail();
                }
                if (result.ToString() == testValues[i])
                {
                    Assert.Fail();
                }
            }
        }
    }
}
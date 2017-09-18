using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mary_Thomas_SSE662_Project1_a
{
    public static class Calculations
    {
        public static double getCos(string num)
        {
            double result = 0;
            if (double.TryParse(num, out result))
            {
                result = double.Parse(num);
                return Math.Cos(result);
            }
            else
            {
                return -99;
            }
        }
    }
}

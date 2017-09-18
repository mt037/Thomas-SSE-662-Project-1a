using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mary_Thomas_SSE662_Project1_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate cosine: ");
            string num = Console.ReadLine();
            Console.WriteLine(Calculations.getCos(num));
            Console.ReadKey();
        }
    }
}

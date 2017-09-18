using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thomas_SSE_662_Project_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            TxtFile file = new TxtFile();
            file.writeFile(@"C:\Users\Public\TestFolder\test.txt", "This, is, a, test!");
            Console.WriteLine(file.readFile(@"C:\Users\Public\TestFolder\test.txt"));
        }
    }
}

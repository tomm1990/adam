using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 100.00;
            int y = 100;
            if ((double)y==(int)x)
            {
                Console.WriteLine("t");
            }
            else
            {
                Console.WriteLine("f");
            }
        }
    }
}

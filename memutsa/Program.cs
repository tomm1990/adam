using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memutsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] arr = new double [31];
            double count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                double a = double.Parse(Console.ReadLine());
                count = a + count;
            }
            Console.WriteLine(count/31);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task19
{
    class Program
    {
        public static int mod(int a, int b)
        {
            int count = 0;
            for (int i = b; i <= a; i=i+b)
            {
                count++;
            }
            return a - (b * count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(mod(10, 3));
        }
    }
}

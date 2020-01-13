using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int i = 0;
            while (i < 5)
            {
                int x = rnd.Next(0, 10);
                Console.WriteLine(x);
                Console.ReadKey();
                i++;
            }

            byte []arr  = new byte [10];
            rnd.NextBytes(arr);
            foreach(byte b in arr)
                Console.WriteLine(b);
        }
    }
}

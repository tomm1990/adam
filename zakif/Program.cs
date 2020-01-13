using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zakif
{
    class Program
    {
        static void Main(string[] args)
        {
            int zakif = int.Parse(Console.ReadLine());
            while (zakif != -1)
            {
                Console.WriteLine("zakif : "+zakif);
                zakif = int.Parse(Console.ReadLine());
            }
        }
    }
}

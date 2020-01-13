using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("One");
                    print();
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Three");
                    break;
                
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
        }

        public static void print()
        {
            Console.WriteLine("Print()");
            
        }
    }
}

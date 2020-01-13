using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passove_rtask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            arr[0] = 0;
            arr[1] = 1;
            Console.WriteLine(0);
            Console.WriteLine(1);
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                Console.WriteLine(arr[i]);
            }

        }
    }
}

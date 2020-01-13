using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int num = arr[size - 1];
            for (int k = 9; k >= 0; k--)
            {
                if (k != 0)
                {
                    arr[k] = arr[k-1];
                }
            }
            arr[0] = num;
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}

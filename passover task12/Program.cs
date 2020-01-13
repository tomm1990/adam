using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task12
{
    class Program
    {
        static public int[] task11(int[] arr , int k)
        {
            int num = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    num = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = num;
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 9, 3, 8, 11, 14 };
            int k = 4;
            int[] arr2 = task11(arr,3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}

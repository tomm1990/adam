using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            double[] arr = new double[size];
            double[] arr2 = new double[size];
            double[] arr_new = new double[size];
            double count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
                arr2[i] = double.Parse(Console.ReadLine());
                arr_new[i] = arr[i] + arr2[i];
                count = (arr[i] * arr2[i]) + count;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == size - 1)
                {
                    Console.Write(arr_new[i]);
                }
                else
                {
                    Console.Write(arr_new[i] + ",");
                }

            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != size - 1)
                {
                    Console.Write((arr[i] + "*" + arr2[i]) + "+");
                }
                else
                {
                    Console.Write((arr[i] + "*" + arr2[i]) + "=" + count);
                }
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task7
{
    class Program
    {

        static public bool chen(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr.Length  || arr[i] < 1)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(chen(arr));
        }
    }
}

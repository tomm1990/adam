using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int run = int.Parse(Console.ReadLine());
            int[] arr = { 34, 65, 789, 21 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == run)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > run)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}

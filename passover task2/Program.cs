using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 2
            char[] arr2 = new char[10];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = char.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int k = 0; k < arr2.Length; k++)
            {
                if(k != arr2.Length - 1)
                {
                    if (arr2[k] + 1 == arr2[k + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}

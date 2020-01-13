using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random ();
            int num = 0;
            int[] counts = new int[10];
            for (int i = 0; i < 50; i++)
            {
                num = rnd.Next(1, 10);
                counts[num - 1]++;
            }
            int max = 0;
            int max_ind = 0;
            for (int i = 0; i < 10; i++)
            {
                if (max < counts[i])
                {
                    max = counts[i];
                    max_ind = i+1;
                }
            }
            Console.WriteLine("the num:"+(max_ind+1)+"_"+"shows"+max);
            for (int i = 0; i < 10; i++)
            {
                if (i != max_ind)
                {
                    Console.WriteLine("the num:"+(i+1)+"_"+"shows"+counts[i]);
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task18
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 14;
            int[] rains = new int[size];
            for (int i = 0; i < size; i++)
            {
                rains[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            int count_of_week = 0;
            int k = 0;
            int max_rain = 0;
            int i_2 = 0;
            for (int i = 0; i < size; i=i+7)
            {
                i_2 = i;
                while (k<8)
                {
                    if (rains[i_2] > 0)
                    {
                        count++;
                    }
                    k++;
                    i_2++;  
                }
                if (count==7)
                {
                    count_of_week++;
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (max_rain < rains[i])
                {
                    max_rain = rains[i];
                }
            }
            Console.WriteLine("the max day is:"+max_rain);
            Console.WriteLine("there was:"+count_of_week+"raining times in this year");
        }
    }
}

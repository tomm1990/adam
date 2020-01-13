using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i <size; i++)
            {
                arr[i] = rnd.Next(10,51);
            }
            int count = 0;
            for (int i = 0; i < size; i++)
            {

                if (i<size-2)
                {
                    while (arr[i] < arr[i + 1])
                    {
                        i++;
                    }
                }
                count++;
            }
            int[,] mat = new int[3, count];
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    i = mat[1, i]; //start
                    while (arr[i] < arr[i + 1])
                    {
                        i++;
                    }
                    i = mat[2, i]; //finish
                }
            }
            for (int i = 0; i < count; i++)
            {
                mat[i, 3] = mat[i, 2] - mat[i, 1]; //hefresh
            }
            int max = 0;
            int max_ind_finish = 0;
            int max_ind_start = 0;
            for (int i = 0; i < count; i++)
            {
                if (mat[i, 3] > max)
                {
                    mat[i, 3] = max;
                    max_ind_finish = mat[i, 2];
                    max_ind_start = mat[i, 1];
                }
            }
            Console.WriteLine("the lenght of the longest is:"+max);
            for (int i = max_ind_start; i < max_ind_finish; i++)
            {
                Console.WriteLine(arr[i]);
            }




                     
        }
    }
}

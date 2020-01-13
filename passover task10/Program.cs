using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task10
{
    class Program
    {
        static public bool a(int [] arr)
        {
            int k = 0;
            for (int i = 0; i < 20; i++)
                {
                    while (k < 20)
                    {
                        if (arr[k] == arr[i])
                        {
                            return false;
                        }
                        k++;
                    }
                }
            return true;
        }

        static void Main(string[] args)
        {
            ex10Tom();
            //Random rnd = new Random();
            //int size = 4;
            //int[] arr = new int[size];
            //int num = 0;
            //int count = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = rnd.Next(0, size);
            //}
            //while (count!=20)
            //{
            //    int last_index = 0;
            //    num = rnd.Next(0, size);
            //    for (int i = 0; i < size; i++)
            //    {
            //        if (num == arr[i])
            //        {
            //            num = rnd.Next(0, size);
            //            break;
            //        }
            //        arr[last_index] = num;
            //        count++;
            //        last_index++;
            //    }
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //while (a(arr) != true)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        arr[i] = rnd.Next(0, size);
            //    }
            //}
            //for (int m = 0; m < size; m++)
            //{
            //    Console.WriteLine(arr[m]);
            //}
        }

        static void ex10Tom() {
            Random rnd = new Random();
            int size = 20, count = 0;
            int[] arr = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            while (count != size)
            {
                int num = rnd.Next(1, 21);
                if (!exists(arr, num))
                {
                    arr[count++] = num;
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("num {0} is : {1}",i,arr[i]);
            }
        }

        static bool exists(int [] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num) return true;
            }
            return false;
        }
    }
}

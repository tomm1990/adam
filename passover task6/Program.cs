using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task6
{
    class Program
    {
        static public bool down(int[] arr)
        {
            bool min = false;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    return false;
                }
            }
            if (arr.Length > 2)
            {
                if (arr[1] < arr[0] && arr[1] < arr[2])
                {
                    min = true;
                }
                else
                {
                    min = false;
                }

                if (min == true)
                {
                    for (int i = 1; i < arr.Length - 1; i+=2)
                    {
                        if (arr[i] < arr[i - 1] && arr[i] < arr[i + 1])
                        {
                            min = true;
                        }
                        else
                        {
                            min = false;
                        }
                    }
                    if (min == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    for (int i = 1; i < arr.Length - 1; i+=2)
                    {
                        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                        {
                            min = true;
                        }
                        else
                        {
                            min = false;
                        }
                    }
                    if (min == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;  
            }
        }
    

        static void Main(string[] args)
        {
            int[] arr = new int [5];
            int max = 0;
            bool T = true;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("the max is:"+max);
            if (down(arr)==true)
            {
                Console.WriteLine("the arr is tops");
            }
            else
            {
                Console.WriteLine("the arr is not tops");
            }
        }
    }
}

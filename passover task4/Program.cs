using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task4
{
    class Program
    {
        static public bool task1(int[] Ar)
           {
                 for (int i = 0; i < Ar.Length - 2; i++)
                 {
                     if (Ar[i] > Ar[i + 1])
                    {
                      return false;
                    }
                 }
                 return true;
            }

        static public bool task2(int[] Ar)
        {
            for (int i = Ar.Length-1; i >1; i--)
            {
                if (Ar[i] > Ar[i -1])
                {
                    return false; 
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
            int[] Ar ={};
            if(task1(Ar)==true||task2(Ar) == true)
            {
                Console.WriteLine("sorted arry");
            }
            else
            {
                Console.WriteLine("not sorted arry");
            }
        }
    }
}

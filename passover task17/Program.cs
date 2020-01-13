using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int arrlenght = 0;
            int num2 = num;
            while (num2>0)
            {
                num2 = num2 / 10;
                arrlenght++;
            }
            int[] N = new int[arrlenght];
            int k = 0;
            while (num > 0)
            {
                N[k] = num % 10;
                num = num / 10;
                k++;
            }
            int[] counts = new int[10]; 
            for (int i = 0; i < N.Length; i++)
            {
                counts[N[i]]++;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("the number:"+i+"shows:"+counts[i]);
            }
        }
    }
}


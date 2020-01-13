using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            int x1;
            x1 = 5;
            int x2 = -2;
            int x3 = 8;
            int x4 = 31;

            //int[] arr;
            //arr = new int[6];
            //arr[0] = 5;
            //arr[1] = -2;
            //arr[2] = 8;
            //arr[3] = 31;
            //arr[4] = -11;
            //arr[5] = 15;

            double[] arr2 = { 5,-2,8,31,-11,15,12,33,-45,100,-56};

            //int i = 0;
            //while (i < arr2.Length) {
            //    Console.WriteLine(arr2[i]);
            //    i++;
            //} 
            double sum_all= 0,sum1=0 , sum2 = 0;
            int i = 0 ;
            double x ;
            while(i<arr2.Length) 
            {
                x = arr2[i];
                arr2[i] = -x;
                i++;      
            }
            i = 0;
            while (i<arr2.Length)
            {
               if (arr2[i] % 2 == 0)
               {
                   sum = sum + arr2[i];
                    k++;
                }
                i++;
            }
            double avg = sum / k;
            Console.WriteLine("the avg is" + avg);

            //i = 0;
            //while (i < arr2.Length)
            //{
            //    if (arr2[i] % 2 == 0)
            //    {
            //        sum1 = sum1 + arr2[i];  
            //    }
            //    else
            //    {
            //        sum2 = sum2 + arr2[i];
            //    }
            //    i++; 
            //}
            //sum_all = sum2 - sum1;
            //Console.WriteLine("the sumall" + sum_all);
        }
    }
}

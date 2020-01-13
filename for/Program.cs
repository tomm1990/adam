using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 5; i++) {
            //    Console.WriteLine(i);
            //} 

            //int[] arr = { 4, 7 ,- 2};

            //for (int i = 0; i<5; i++) 
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //double sum=0;
            //double[] arr = { 3.4,6.2,-5.2,10.2};
            //for (int i = 0; i<arr.Length; i++) 
            //{
            //    sum+= arr[i];
            //}
            //Console.WriteLine(sum);
            //int sum = 0;
            //int[] arr = { 5, 2, -2, 16, 7, 31, -9, 1, 3, 6, 15 };
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    if(arr[i]%2!=0)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine(sum);
            //int k = 0; 
            //int[] arr = { 2, 2, -2, 16, 7, 31, -9, 1, 3, 2,2 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 2) 
            //    {
            //        k ++;
            //    }
            //}
            //Console.WriteLine(k);

            //int sum = 0;
            //int[] arr1 = { 2, 2, -2, 16, 7, 31, -9, 1, 3, 2, 2 };
            //int[] arr2 = { 5, 2, -2, 16, 7, 31, -9, 1, 3, 6, 15 };
            //for (int i = arr1.Length-1; i >=0; i--)
            //{
            //    if (arr1[i] == arr2[i]) 
            //    {
            //        sum++;
            //    }
            //}
            //Console.WriteLine(sum);
            string x = "yes";
            int[] poly = { 3, 5, 6, 6, 5, 3 };
            for (int i = 0, k = 1; i<poly.Length-k; i++, k++)
            {
                if (poly[i] == poly[poly.Length - k])
                {
                    x = "yes";
                }
                else
                {
                    x = "no";
                }
               
            }
            Console.WriteLine(x);
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrRec
{
    class Program
    {
        static int[] BubleSort(int [] arr,int i = 0, int j =1)
        {
            if (i == arr.Length) return arr;
            if (j == arr.Length) return BubleSort(arr, i++, j);
            if (arr[i]<arr[j])
            {
                int t = arr[i];
                arr[i] = arr[j];
                t = arr[j];
            }
            return BubleSort(arr,i++,j++);
        } 
        static void Main(string[] args)
        {
            int [] arr = { 1, 3, 2, 5 };
            BubleSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

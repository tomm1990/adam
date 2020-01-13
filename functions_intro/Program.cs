using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_intro
{
    class Program
    {

        static void Main(string[] args)
        {

            
            int[] temp = {
                1,2,5,7,13,17
            };
            Console.WriteLine(isPrimeArr(temp));
            //Console.WriteLine(ex4(temp));
            //Console.WriteLine(sam_arr(temp));
            //Console.WriteLine(sum_odd(temp));  
            //Console.WriteLine(count_in_arr(temp,5));
            //char[] temp2 =
            //{
            //    'a','s','j','l'
            //};
            //Console.WriteLine(from_arr_to_string(temp2));
            //up_or_down(temp);

        }

        public static void func()
        {
            Console.WriteLine("hello");
        }
        public static int sum(int x,int y)
        {
            int num1 = x;
            int num2 = y;
            int ans = num1 + num2;
            return ans;
        }
        public static int ex4(int [] arr)
        {
            int max = int.MinValue;
            int index_max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index_max = i;
                }  
            }
            return index_max;
        }
        public static double sam_arr(int[] arr )
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
                sum = sum + arr[i];
            }
            return sum/count;
        }
        public static int sum_odd(int [] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 != 0)
                {
                    sum = sum + arr[i];  
                }
            return sum;
        }
        public static int count_in_arr(int[] arr, int num)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    count++;
                }
            }
            return count;
        }
        public static string from_arr_to_string(char[] arr)
        {
            string x="";
            for (int i = 0; i < arr.Length; i++)
            {
                x+= arr[i];
            }
            return x;
        }
        public static bool arr_is_even(int[] arr)
        {
            bool A=true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                   A= true;
                }
                else
                {
                    A = false;
                    return A;
                }
            }return A;
        }
        public static void up_or_down(int[] arr)
        {
            string x = "";
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i + 1] >= arr[i])
                {
                    x = "up";
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i + 1] <= arr[i])
                {
                    x = "down";
                }
                else
                {
                    x = "regular";
                }
            }
            Console.WriteLine(x);
        }
        public static bool isPrimeArr(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool isPrime(int num)
        {
            for(int i=2; i < num; i++)
            {
                if(num% i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

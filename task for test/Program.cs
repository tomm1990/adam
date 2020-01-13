using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_for_test
{
    class Program
    {
        public static int[] from_num_to_arr(int num)
        {
            int num2 = num;
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            int[] arr = new int[count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (num2 % 10) * (Math.Pow(10,));
                num2 = num2 / 10;
            }
            return arr;
        }

        public static int CreatNewNum(int num, char x)
        {
            int[] arr = from_num_to_arr(num);
            int new_num = 0;
            if (x == 'e')
            {
                for (int i = 0; i < arr.Length; i = i + 2)
                {
                    new_num = new_num + arr[i];
                }
            }
            if (x == 'o')
            {
                for (int i = 1; i < arr.Length; i = i + 2)
                {
                    new_num = new_num + arr[i];
                }
            }
            return new_num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CreatNewNum(123, 'e'));

            Console.WriteLine();
        }
    }
}

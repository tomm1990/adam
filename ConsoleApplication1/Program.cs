using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void print(int i)
        {
            while (i>0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        static void printRec(int i)
        {
            if (i == 0)
                return;
            Console.WriteLine(i);
            printRec(i - 1);
        }
        static int SumTillNum(int i)
        {
            int sum=0;
            while (i>0)
            {
                sum = sum + i;
                i--;
            }
            return sum;
        }
        static int SumTillNumRec(int i)
        {
            if (i == 0)
                return 0;
            return i + SumTillNum(i - 1);
        }
        static int Factorial(int i)
        {
            int sum = 1;
            while (i>0)
            {
                sum = sum * i;
                i--;
            }
            return sum;
        }
        static int FactorialRec(int i)
        {
            if (i == 1)
                return 1;
            return i * FactorialRec(i - 1);
        }
        static int SumDigitsRec(int i)
        {
            if (i <= 0)
                return 0;
            return i % 10 + SumDigitsRec((i - i % 10)/10);
        }
        static int CountInNum(int num , int i)
        {
            int count=0;
            while (num>0)
            {
                if (num%10==i)
                {
                    count++;
                }
                num = (num - (num % 10)) / 10;
            }
            return count;
        }
        static int CountInNumRec(int num, int i)
        {
            if (num <= 0)
                return 0;
            int count = 0;
            if (i == num%10)
            {
                num = (num - (num % 10)) / 10;
                count = count + 1;
                return count + CountInNumRec(num, i);
            }
            num = (num - (num % 10)) / 10;
            return CountInNumRec(num, i);
        }
        static void Print_Even(int num)
        {
            for (int i = 1; i < (num/2)+1; i++)
            {
                Console.WriteLine(2*i);
            }
        }
        static void Print_EvenRec(int num)
        {
             Print_EvenHelp(1,num);

        }
        static void Print_EvenHelp(int i,int num)
        {
            if (i == (num/2)+1)
                return;
            Console.WriteLine(i*2);
            i++;
            Print_EvenHelp(i, num);
        }
        static int Arr_Div(int [] arr , int dig)
        {
            int count = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k]%dig==0)
                {
                    count++;
                }
            }
            return count;
        }
        static int Arr_DivRec(int [] arr, int i)
        {
            return Arr_DivHelp(arr, i);
        }
        static int Arr_DivHelp(int[] arr, int i, int ind=0,int count = 0)
        {
            if (ind == arr.Length)
                return count;
            if (arr[ind]%i==0)
            {
                return Arr_DivHelp(arr, i, ind + 1, count+1);
            }
            return Arr_DivHelp(arr, i, ind + 1, count);
        }
        static  void PrintMat(int i , int j , int [,] mat)
        {
            for (int k = i; k < mat.GetLength(0); k++)
            {
                for (int l = j; l < mat.GetLength(1); l++)
                {
                    Console.Write(mat[i,j]);
                    l++;
                }
                Console.WriteLine("");
                k++;
            }
        }
        static void Main(string[] args)
        {
            //printRec(5);
            //Console.WriteLine(FactorialRec(4));
            //Console.WriteLine(SumDigitsRec(-2));
            //Console.WriteLine(CountInNum(122,2));
            //Console.WriteLine(CountInNumRec(-1,-1));
            //Print_Even(20);
            //Print_EvenRec(11);
            int [] arr = {-3,-2,-1};
            //Console.WriteLine(Arr_Div(arr, 3));
            Console.WriteLine(Arr_DivRec(arr, 3));
        }
    }
}

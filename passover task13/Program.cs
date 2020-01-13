using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task13
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = {1,234,45,4,2,1,2,123,9};
            double[] B = new double[10];
            int k = 0;
            for (int i = 0; i < A.Length; i += 3)
            {
                if (A[i] == 1)
                {
                    B[k] = A[i + 1] + A[i + 2];
                    Console.WriteLine(B[k]);
                }
                if (A[i] == 2)
                {
                    B[k] = A[i + 1] - A[i + 2];
                    Console.WriteLine(B[k]);
                }
                if (A[i] == 3)
                {
                    B[k] = A[i + 1] * A[i + 2];
                    Console.WriteLine(B[k]);
                }
                if (A[i] == 4)
                {
                    B[k] = A[i + 1] / A[i + 2];
                    Console.WriteLine(B[k]);
                }
                k++;
            }
        }
    }
}

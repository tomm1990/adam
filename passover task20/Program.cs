using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task20
{
    class Program
    {
        static bool snake(int [,] mat)
        {
            for (int cole = 0; cole < mat.GetLength(1); cole++)
            {
                if (cole%2==0)
                {
                    for (int row = 0; row < mat.GetLength(0)-1; row++)
                    {
                        if (row == mat.GetLength(0)-1)
                        {
                            if (mat[row,cole]<mat[row,cole+1])
                            {
                                return false;
                            }
                        }
                        if (mat[row,cole]>mat[row,cole+1])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int row = mat.GetLength(0) - 1; row >= 0; row--)
                    {
                        if (row == 0)
                        {
                            if (mat[row, cole] < mat[row, cole + 1])
                            {
                                return false;
                            }
                        }
                        if (mat[row, cole] < mat[row, cole + 1])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] mat =
                {
                 {1,6,7},
                 {2,5,8},
                 {3,4,9}
                };
            Console.WriteLine(snake(mat));
        }
    }
}

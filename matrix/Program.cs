using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] mat;
            //mat = new int[3,5];
            //mat[0, 0] = 4;
            //mat[0, 1] = 6;
            //mat[0, 2] = -9;
            //int x = mat[0, 1];
            //Console.WriteLine(x);

            int[,] mat2 = {
                { 4, 6, -9, 1, 4},
                { 4, 7, 11,-2, 8},
                { 7,11, 4 ,21,-5}
            };

            //int rows = mat2.GetLength(0);
            //int cols = mat2.GetLength(1);
            //for (int row = 0; row < rows; row++)
            //{
            //    for(int col = 0; col < cols; col++)
            //    {
            //        Console.Write(mat2[row,col]+"\t");
            //    }
            //    Console.WriteLine();
            //}
            //int sum = 0;
            for (int x = mat2.GetLength(0)-1; x>-1 ;x--)
            {
               
                for (int y =mat2.GetLength(1)-1; y>-1;y--)
                {

                    //if (mat2[x, y] % 2 == 0)
                    //{
                    //    sum=sum+mat2[x, y];
                    //}
                    Console.Write(mat2[x, y] + "\t"); ;
                }
                Console.WriteLine();
            }/*Console.Write(sum);*/
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat3 = new int[3,3];
            int[,] mat1 = {
                { 1, 2, -3},
                { 6, -5, 11},
                { 7,8, 0 }
            };
            int[,] mat2 =
            {
                {-11,20,8},
                {-6,7,9 },
                {11,1,0 }
            };
            for (int x =0; x <mat1.GetLength(0); x++)
            {
                for (int y = 0; y < mat1.GetLength(1); y++)
                {   
                     mat3[x,y]=  mat1[x, y] + mat2[x,y] ; 
                   
                }
                
            }
            for (int x =0; x < mat3.GetLength(0); x++)
            {

                for (int y = 0; y < mat3.GetLength(1); y++)
                {
                    Console.Write(mat3[x, y] + "\t"); ;
                }
                Console.WriteLine();
            }
            

        }
    }
}

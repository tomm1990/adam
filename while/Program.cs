using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            //int loop = 200;
            //while ( loop > -200)
            //{
            //    if (loop % 2 == 0)
            //    {
            //        Console.WriteLine(loop);
            //    }
            //    loop--;
            //}
            Console.WriteLine("enter grades");
            int loop = 0;
            while (loop < 5)
            {
                Console.WriteLine("enter grade 1");
                int grade_1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter grade 2");
                int grade_2 = int.Parse(Console.ReadLine());
                if (grade_1 >= 0 && grade_2 >= 0 && grade_1 <= 100 && grade_2 < 101) {
                    if (grade_1 > grade_2)
                    {
                        Console.WriteLine("The hier grade");
                        Console.WriteLine(grade_1);

                    }

                    else if (grade_2 > grade_1)
                    {
                        Console.WriteLine("The hier grade");
                        Console.WriteLine(grade_2);
                    }
                    else
                        Console.WriteLine("equals");
                }
                else if (grade_2 > 100 && grade_1 > 100)
                    Console.WriteLine("the numbers is above 100");
                else if (grade_2 < 0 && grade_1 < 0)
                    Console.WriteLine("the numbers is under 0"); 
                    
            }
        }
    }
}

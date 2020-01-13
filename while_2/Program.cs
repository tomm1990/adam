using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter grades");
            int loop = 0;
            double avg_max = 0;
            while (loop < 5)
            {
                Console.WriteLine("enter grade 1");
                double grade_1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("enter grade 2");
                double grade_2 = Double.Parse(Console.ReadLine());

                double avg = (grade_1 + grade_2)/2 ;
                if (avg > avg_max)
                {
                    avg_max = avg;
                }


                loop++;
            }
            Console.WriteLine("this is the max avg");
            Console.WriteLine(avg_max);


        }
    }
}

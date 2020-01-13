using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zakif_grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Double avg;
            double sum = 0;
            double count = 0;
            double grade = double.Parse(Console.ReadLine());
            while (grade != -1)
            {
                Console.WriteLine("grade : " + grade);
                grade = Double.Parse(Console.ReadLine());
                sum = sum + grade;
                count++ ;
            }
            Console.WriteLine("this is the avg");
            avg = (sum/count);
            Console.WriteLine(avg);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151e36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name for std1");
            string name = Console.ReadLine();
            Student std1 = new Student(name);
            Console.WriteLine("name for std2");
            name = Console.ReadLine();
            Student std2 = new Student(name);
            int i = 0;
            int fails_std2 = 0;
            int fails_std1 = 0;
            Console.WriteLine("enter 3 grades for " + std1.cw_name() + "and enter 3 grades for " + std2.cw_name());
            while (i < 3)
            {  
                Console.WriteLine("enter grade for " + std1.cw_name());
                double x = double.Parse(Console.ReadLine());
                while (x < 0)
                {
                    Console.WriteLine("enter a grade above 0");
                    x = double.Parse(Console.ReadLine());
                }
                std1.AddGrd(x);
                Console.WriteLine("grade for "+ std2.cw_name());
                double y = double.Parse(Console.ReadLine());
                while (y < 0)
                {
                    Console.WriteLine("enter a grade above 0");
                    y = double.Parse(Console.ReadLine());
                }              
                std2.AddGrd(y);
                i++;
                if (x<55)
                {
                    fails_std1++;
                }
                if (y<55)
                {
                    fails_std2++;
                }
            }
            Console.WriteLine(std1.cw_name()+"failed "+fails_std1+" times");
            Console.WriteLine(std2.cw_name()+"failed "+fails_std2+" times");
            Console.WriteLine("tasks of avrges");
            Console.WriteLine(std1.cw_name() + "avrage is: "+ std1.Avg());
            Console.WriteLine(std2.cw_name() + "avrage is: " + std2.Avg());
            if (std1.Avg() > 55 && std2.Avg() < 55 || std1.Avg() < 55 && std2.Avg() > 55)
            {
                if (std1.Avg()>std2.Avg())
                {
                    Console.WriteLine(std1.Avg()-std2.Avg());
                }
                else
                {
                    Console.WriteLine(std2.Avg() - std1.Avg());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p142t21
{
    class Program
    {
        public static void task(string id,int num_jumps)
        {
            double max = 0;
            double[] jumps = new double[num_jumps];
            Jumper x = new Jumper(id);
            double count = 0;
            for (int i = 0; i < num_jumps; i++)
            {
                Console.WriteLine("pls enter the" + (i + 1) + "jump");
                jumps[i] = double.Parse(Console.ReadLine());
                while (jumps[i] <= 0)
                {
                    Console.WriteLine("pls write a jump above 0");
                    jumps[i] = double.Parse(Console.ReadLine());
                }
                if (max < jumps[i])
                {
                    max = jumps[i];
                }
                count = count + jumps[i];
            }
            Console.WriteLine(x.Tostring());
            x.SetRecord(max);
            Console.WriteLine("max is: "+max);
            for (int i = num_jumps-3; i < num_jumps; i++)
            {
                x.SetJumps(jumps[i]);
                if (max == jumps[i])
                {
                    Console.WriteLine("ready for the competition"); ;
                }
            }
            Console.WriteLine("the avrage is "+(count/num_jumps));
            if (max> (count / num_jumps))
            {
                Console.WriteLine("the difference is: " +(max - (count / num_jumps)));
            }
            else
            {
                Console.WriteLine("the difference is: " + ((count / num_jumps) - max));
            }
        }
        static void Main(string[] args)
        {
            task("aaa",4);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = 0;
            int[] counts = new int[10];
            for (int i = 0; i < 3; i++)
            {
                num = rnd.Next(1, 100);
                if (num ==100)
                {
                    counts[9]++;
                }
                else
                {
                    if (num%10==1&&num>10&&num<100)
                    {
                        counts[(num/10) - 1]++;
                    }
                    if(num<11)
                    {
                        counts[0]++;
                    }
                    if (num%10!=0&&num>10&&num<100)
                    {
                        num = num / 10;
                        counts[num]++;
                    }
                }
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("there are:"+counts[i]+"that got between:"+(i*10)+"to"+(i*10+10));
            }
        }
    }
}

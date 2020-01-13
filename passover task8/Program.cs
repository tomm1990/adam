using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover_task8
{
    class Program
    {
        static public bool Chen(int [] Time)
        {
            bool K = true;
            for (int i = 0; i < Time.Length; i++)
            {
                if (Time[0] < Time[i])
                {
                    K = false;
                }
            }
            return K;
        }

        static public double Chen_2_U(int [] Time)
        {
            if (Chen(Time)==false)
            {
                
            }
        }

        static void Main(string[] args)
        {

        }
    }
}

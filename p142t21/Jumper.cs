using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p142t21
{
    class Jumper
    {
        private string id;
        private double record;
        private double [] jumps;
        public Jumper()
        {

        }
        public Jumper(string id)
        {
            this.id = id;
            this.record = 0;
            this.jumps = new double[3];
            for (int i = 0; i < 3; i++)
            {
                jumps[i] = 0;
            }
        }
        public string Tostring()
        {
            return "id: " + this.id + "record: " + this.record + "jump1: " + this.jumps[0] + "jump2: " + this.jumps[1] + "jump3: " + jumps[2];
        }  
        public void SetJumps(double x)
        {
            for (int i = 0; i < 3; i++)
            {
                if (jumps[i]==0)
                {
                    jumps[i] = x;
                }
            }
        }
        public void SetRecord( double x)
        {
            this.record = x;
        }
    }
}

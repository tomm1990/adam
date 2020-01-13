using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p181t32
{
    class TomAndJery
    {
        private int Tom_place;
        private int Jerry_place;
        private Random rnd;
        public TomAndJery()
        {
            this.rnd = new Random();
            this.Tom_place = 10;
            this.Jerry_place = 40;
        }
        //
        public void start()
        {
            while (Tom_place>0&&Tom_place<51||Jerry_place>0&&Tom_place<51)
            {
                if (If_TOm_Win()==true)
                {
                    Console.WriteLine("tom wins");
                    break;
                }
                this.Tom_place =WM_to_go(this.Tom_place);
                if (If_Jerry_Win() == true)
                {
                    Console.WriteLine("Jerry wins");
                    break;
                }
                this.Jerry_place =WM_to_go(this.Jerry_place);
            }

        }
        //
        public int WM_to_go(int num)
        {
            int x = rnd.Next(-5, 5);
            num = num + x;
            return num;
        }
        //
        public bool If_Jerry_Win()
        {
            if (this.Tom_place==WM_to_go(this.Jerry_place))
            {
                return true;
            }
            return false;
        }
        public bool If_TOm_Win()
        {
            if (this.Jerry_place == WM_to_go(this.Tom_place))
            {
                return true;
            }
            return false;
        }
        
    }
}

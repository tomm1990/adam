using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p173t13
{
    class Park
    {
        private int floor_A;
        private int floor_B;
        public Park()
        {
            this.floor_A = 100;
            this.floor_B = 100;
        }

        public int Get_floorA()
        {
            return this.floor_A;
        }
        public int Get_floorB()
        {
            return this.floor_B;
        }
//
        public string If_Place()
        {
            if (floor_A==0 && floor_B==0)
            {
                return "no place";
            }
            if (floor_B==0&& floor_B == 0)
            {
                return "A";
            }
            if (floor_A ==0 && floor_B != 0)
            {
                return "B";
            }
            return "A";
        }
 //
        public void MoreCars()
        {
            if (If_Place() == "A")
            {
                this.floor_A = this.floor_A + 1;
            }
            if (If_Place() == "B")
            {
                this.floor_B = this.floor_B + 1;
            }
        }
//
        public  void LessCars(string x)
        {
            if (x == "A")
            {
                this.floor_A = this.floor_A - 1;
            }
            if (x == "B")
            {
                this.floor_B = this.floor_B - 1;
            }
        }
    }
}

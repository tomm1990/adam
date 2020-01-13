using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDates
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date() { }
        public Date(int x, int y, int z)
        {
            this.set_new_day(x);
            this.set_new_month(y);
            this.set_new_year(z);
            if (x > 0 && x < 32)
            {
                this.day = x;
            }
            if ( y > 0 && y <13)
            {
                this.month = y;
            }
            if( z > 0 && z < 3000)
            {
                this.year = z;
            }
        }
        public int getday()
        {
            return this.day;
        }
        public int getmonth()
        {
            return this.month;
        }
        public int getyear()
        {
            return this.year;
        }
        public void set_new_day(int newday)
        {  
                this.day = newday;   
      }
        public void set_new_month(int newmonth)
        {
                this.month = newmonth;
        }
        public void set_new_year(int newyear)
        {
                this.year = newyear;
        }
        public override string ToString()
        {
            string str = this.day + "/" + this.month +"/"+ this.year;
            return str;
        }
        public bool Equals(Date D)
        {
            if (this.day == D.day && this.year == D.year && this.month == D.month)
            {
                return true;
            }
            return false;
        }
    }
}

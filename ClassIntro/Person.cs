using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Person
    {
        private int id;
        private string name;
        private double height;
        private Date dob;

        public Person(int id, string name, double height, int day, int month, int year)
        {
            this.id = id;
            this.name = name;
            this.height = height;
            this.dob = new Date(day, month, year);
        }

        public Person() {}

        public Person(int x,string y,double z)
        {
            this.id = x;
            this.name = y;
            this.height = z;
        }
        public int getId()
        {
            return this.id;
        }

        public void setId(int newid)
        {
            this.id = newid;
        }
        public Date get_Date()
        {
            return this.dob;
        }
        public void set_date(Date newdate)
        {
            this.dob = newdate;
        }
        public bool Equals(Person D)
        {
            if (this.id == D.id && this.name == D.name && this.height == D.height && this.Equals(D))
            {
                return true;
            }
            return false;
        }

    }
}

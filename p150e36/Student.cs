using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Student
    {
        private string name;
        private double [] grd;

        public Student(string name)
        {
            this.name = name;
        this.grd = new double[3];
        }
        public string cw_name()
        {
        return this.name;
        }
        public void AddGrd(double grd1)
        {    
            for (int i = 0; i < this.grd.Length; i++)
            {
                if (this.grd[i]==0)
                {
                    this.grd[i] = grd1;
                    break;
                }
            }
        }
        public double[] GetGrd()
        {
        return this.grd;
        }
        public double MinGrd()
        {
            double min = double.MaxValue;
            for (int i = 0; i < this.grd.Length; i++)
            {
                if (min>this.grd[i])
                {
                    min = this.grd[i];
                }
            }
            return min;
        }
        public double MaxGrd()
        {
            double max = double.MinValue;
            for (int i = 0; i < this.grd.Length; i++)
            {
                if (max < this.grd[i])
                {
                    max = this.grd[i];
                }
            }
            return max;
        }
        public double Avg()
        {
            double count = 0;
            for (int i = 0; i < this.grd.Length; i++)
            {
                count = count + this.grd[i];
            }
            return count / (this.grd.Length);
        }
        public string Tostring()
        {
            string str = this.name + "/" + this.grd + "/" + MinGrd() + "/" + MaxGrd() + "/" + Avg();
            return str;
        }

    }


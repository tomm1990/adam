using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_1
{
    class Student
    {
        private int id;
        private string name;
        private string kita;
        private int[,] grades;

        public Student()
        {
            
        }
        public  Student(int id, string name , string kita)
        {
            this.id = id;
            this.name = name;
            this.kita = kita;
            this.grades = new int[4, 5];
        }
        public void add_grade(int job , int grade)
        {
            for (int i = 0; i < 4; i++)
            {
                if (grades[i, job] == 0)
                {
                    grades[i, job] = grade;
                }
            }
        }
        public double memutsa()
        {
            double count_grades = 0;
            int hm_grades = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 4; k++)
                {

                    if (grades[i,k]!=0)
                    {
                        count_grades = grades[i, k] + count_grades;
                        hm_grades++;
                    }
                }
            }
            return (count_grades / hm_grades);
        }
        public int max_grade()
        {
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (grades[i, k] > max)
                    {
                        max = grades[i, k];
                    }
                }
            }
            return max;
        } 
        public int get_id()
        {
            return this.id;
        }
        public int[,] get_grades()
        {
            return this.grades;
        }
        public string get_name()
        {
            return this.name;
        }
        public string get_kita()
        {
            return this.kita;
        }
    }
}

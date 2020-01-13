using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_1
{
    class Teacher
    {
        private int id;
        private string name;
        private int job = 1;
        private int salary;
        private string kind_of_teacher;
        private int[] classes;

        public Teacher()
        {

        }
        public Teacher(int id, string kind_of_teacher, string name)
        {
            this.id = id;
            this.name = name;
            this.kind_of_teacher = kind_of_teacher;
            this.salary = 0;
        }

        public void new_salary(int salary)
        {
            this.salary = salary;
        }
        public int equal_salary(Teacher tch1)
        {
            if (this.salary == tch1.salary)
            {
                return 1;
            }
            return 9;
        }
        public string Subject()
        {
            return this.kind_of_teacher;
        }
        public int get_id()
        {
            return this.id;
        }
        public string get_name()
        {
            return this.name;
        }
        public int get_salary()
        {
            return this.salary;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_1
{
    class Employee
    {
        private int id;
        private string name;
        private int kind_of_job;
        private int salary;

        public Employee()
        {

        }
        public Employee(int id, int kind_of_job , string name)
        {
            this.id = id;
            this.kind_of_job = kind_of_job;
            this.name = name;
            this.salary = 0;
        }

       public void new_salary(int salary)
        {
            this.salary = salary;
        }
        public int eqoual_salary(Employee emp1)
        {
            if(emp1.salary == this.salary)
            {
                return 1;
            }
            return 9;
        }
        public int IsTeacher()
        {
            if (this.kind_of_job == 1)
            {
                return 1;
            }
            return 0;
        }
        public  int get_kind_of_job()
        {
            return this.kind_of_job;
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

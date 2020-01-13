using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_1
{
    class School
    {
        private string name;
        private int add;
        private string type;
        private Employee[] employees;
        private Teacher[] teacher;
        private Student[] students;
        public School()
        {

        }
        public School(string name, int add, string type)
        {
            this.employees = new Employee[100];
            this.students = new Student[250];
            this.teacher = new Teacher[75];
            this.name = name;
            this.add = add;
            this.type = type;
        }
        public void add_employee(Employee emp1)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = emp1;
                    break;
                }
            }
        }
        public void add_student(Student std1)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]== null)
                {
                    students[i] = std1;
                    break;
                }
            }
        }
        public void add_teacher(Teacher tch1)
        {
            for (int i = 0; i < this.teacher.Length; i++)
            {
                if (teacher[i] == null)
                {
                    teacher[i] = tch1;
                    break;
                }
            }
        }
        public int hm_kind_of_job(int kind_of_job)
        {
            int count = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].get_kind_of_job() == kind_of_job)
                {
                    count++;
                }
            }
            return count;
        }
        public int[,] get_grades_by_id(int id)
        {
            for (int i = 0; i < 250; i++)
            {
                if (students[i].get_id() == id)
                {
                    return students[i].get_grades();
                }
            }
            return null;
        }
        public void cw_all_employees()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    Console.Write((i + 1) + ")" + "[name:" + employees[i].get_name() + "]");
                    Console.Write("[id:" + employees[i].get_id() + "]");
                    Console.Write("[salary:" + employees[i].get_salary() + "]");
                    if (employees[i].get_kind_of_job() == 1)
                    {
                        Console.Write("[kind of job: teacher]");
                    }
                    if (employees[i].get_kind_of_job() == 2)
                    {
                        Console.Write("[kind of job: laborant]");
                    }
                    if (employees[i].get_kind_of_job() == 3)
                    {
                        Console.Write("[kind of job: secretery]");
                    }
                    if (employees[i].get_kind_of_job() == 4)
                    {
                        Console.Write("[kind of job: av bait]");
                    }
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
        public void cw_all_teachers()
        {
            for (int i = 0; i < this.teacher.Length; i++)
            {
                if (this.teacher[i]!=null)
                {
                    Console.Write((i + 1) + ")"+ "[name:" + teacher[i].get_name() + "]");
                    Console.Write("[id:" + teacher[i].get_id() + "]");
                    Console.Write("[salary:" + teacher[i].get_salary() + "]");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        public void cw_all_studenst()
        {
            for (int i = 0; i < this.students.Length; i++)
            {
                if (this.students[i]!=null)
                {
                    Console.Write((i + 1)+")" + "[name:" + students[i].get_name() + "]");
                    Console.Write("[id:" + students[i].get_id() + "]");
                    Console.Write("[class:" + students[i].get_kita() + "]");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        public void all_people()
        {
            Console.WriteLine("employees:");
            this.cw_all_employees();
            Console.WriteLine("students");
            this.cw_all_studenst();
            Console.WriteLine("teachers:");
            this.cw_all_teachers();
        }
        public int all_salary()
        {
            int count = 0;
            for (int i = 0; i < this.teacher.Length; i++)
            {
                if (teacher[i]!=null)
                {
                    count = count + teacher[i].get_salary();
                }
            }
            for (int i = 0; i < this.employees.Length; i++)
            {
                if (employees[i]!=null)
                {
                    count = count + employees[i].get_salary();
                }
            }
            return count;
        }
    }
}

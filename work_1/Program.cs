using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(456,3,"avi");
            Employee emp2 = new Employee(454, 2, "adam");
            Teacher tch1 = new Teacher(7809, "Computers","moti");
            Teacher tch2 = new Teacher(7804, "Scientific", "ido");
            Student std1 = new Student(3465,"tom","a2");
            Student std2 = new Student(3464, "ran", "a1");
            School sch1 = new School("g1",123, "skilled");
            sch1.add_employee(emp1);
            sch1.add_employee(emp2);
            sch1.add_student(std1);
            sch1.add_student(std2);
            sch1.add_teacher(tch1);
            sch1.add_teacher(tch2);
            sch1.all_people();
            emp1.new_salary(123);
            emp2.new_salary(321);
            tch1.new_salary(456);
            tch2.new_salary(4562);
            Console.WriteLine("this is all salaries:"+sch1.all_salary()); 
        }
    }
}

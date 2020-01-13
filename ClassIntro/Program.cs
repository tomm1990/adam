using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Person i = new Person();
            Person p1 = new Person(345,"Tom",1.80,25,2,1990);
            Person p2 = new Person(123,"adam",1.90,12,1,2001);
            Person p3 = new Person(124,"ido",1.70,6,4,2002);
            Person p4 = new Person(125,"ori",1.60,5,9,2002);
            p2.setId(p1.getId());
            p2.set_date(p1.get_Date());
                
            if (p1.Equals(p2)== true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("fals");
            }

            
           
           



        }
    }
}

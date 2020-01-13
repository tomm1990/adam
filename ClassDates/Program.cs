using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Date D1,D2,D3;
            D1 = new Date(1, 4, 2018);
            D2 = new Date(12, 4, 2018);
            D3 = new Date(16, 4, 2018);
            D1.set_new_day(16);
            Console.WriteLine(D1.Equals(D3));
            Console.WriteLine(D3.Equals(D1));
            Console.WriteLine(D1.ToString());
            Console.WriteLine(D2.ToString());
            Console.WriteLine(D3.ToString());

            //int x1 = D1.getday();
            //int y1 = D1.getmonth();
            //int z1 = D1.getyear();
            //Console.WriteLine(x1+"/"+y1+"/"+z1);
            //int x2 = D2.getday();
            //int y2 = D2.getmonth();
            //int z2 = D2.getyear();
            //Console.WriteLine(x2 + "/" + y2 + "/" + z2);
            //int x3 = D3.getday();
            //int y3 = D3.getmonth();
            //int z3 = D3.getyear();
            //Console.WriteLine(x3 + "/" + y3 + "/" + z3);
            int[] date1 = {D1.getday() , D1.getmonth(), D1.getyear() };
            int[] date2 = { D2.getday(), D2.getmonth(), D2.getyear() };
            int[] date3 = { D3.getday(), D3.getmonth(), D3.getyear() };
            //for (int i = 0; i < date1.Length; i++)
            //{
            //    Console.Write(date1[i]);
            //    if (i != date1.Length - 1)
            //    {
            //        Console.Write("/");
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < date2.Length; i++)
            //{
            //    Console.Write(date2[i]);
            //    if (i != date2.Length - 1)
            //    {
            //        Console.Write("/");
            //    }
            //}
            //Console.WriteLine(  );
            //for (int i = 0; i < date3.Length; i++)
            //{
            //    Console.Write(date1[i]);
            //    if (i != date3.Length - 1)
            //    {
            //        Console.Write("/");
            //    }
            //}
            //Console.WriteLine(  );
        }
        
    }
}

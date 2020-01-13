using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p173t13
{
    class Program
    {
        public void Cars(char x)
        {
            while (x != 'F')
            {
                Park TLV = new Park();
                Console.WriteLine("choose an action ");
                if (x == 'I' || x == 'i')
                {
                    if (TLV.If_Place()!= "no place")
                    {
                        TLV.MoreCars();
                        TLV.If_Place();
                        Console.WriteLine("in floor A there are " + TLV.Get_floorA() + " places");
                        Console.WriteLine("in floor B there are " + TLV.Get_floorB() + " places");
                    }
                    else
                    {
                        Console.WriteLine(TLV.If_Place());
                    }
                }
                if (x == 'F' || x == 'f')
                {
                    string y = Console.ReadLine();
                    TLV.LessCars(y);
                }
            }
          

        }
        static void Main(string[] args)
        {
        }
    }
}

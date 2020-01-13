using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_5
{
    class Menu
    {
        private string name;
        private Item[] items;

        public Menu()
        {

        }
        public Menu (string name,Item [] x)
        {
            this.name = name;
            this.items = x;
        }  
        public void task_b(string f)
        {
            for (int i = 0; i < this.items.Length; i++)
            {
                if (items[i].exsist(f)==false)
                {
                    Console.WriteLine(items[i].GetCode());
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_5
{
    class Item
    {
        private int cod_of_item;
        private string name_of_item;
        private string[] ingredients;

        public Item()
        {

        }
        public Item(int cod,string name,string [] x)
        {
            this.cod_of_item = cod;
            this.name_of_item = name;
            this.ingredients = x;
        } 
        public int GetCode()
        {
            return this.cod_of_item;
        }
        public string GetName()
        {
            return this.name_of_item;
        }
        public string [] GetIng()
        {
            return this.ingredients;
        }
        public bool exsist(string f)
        {
            for (int i = 0; i < this.ingredients.Length; i++)
            {
                if (this.ingredients[i]!=null)
                {
                    if (f == this.ingredients[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

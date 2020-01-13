using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p103t31
{
    class BankAcount
    {
        public enum Types{
            JUNIOR, ARMY, ADULT
        }
        private static int acount_numbers = 1000;

        private Types account_type;
        private int account_number;
        private int num;
        private string name;
        private int money;

        public BankAcount(Types type)
        {
            this.account_number = acount_numbers;
            acount_numbers++;
            this.account_type = type;
        }

        public BankAcount()
        {
            this.account_number = acount_numbers;
            acount_numbers++;
        }
        public BankAcount(int x, string n, int m)
        {
            this.num = x;
            this.name = n;
            this.money = m;
            this.account_number = acount_numbers;
            acount_numbers++;
        }
        
        public int Get_money()
        { 
            return this.money;
        }
        public int More_money(int x)
        {
            this.money = this.money + x;
            return this.money;
        }
        public int Less_money(int x)
        {
            this.money = this.money - x;
            return this.money;
        }

        public int getAccountNumber() {
            return this.account_number;
        }

        public int getAllNumbers() {
            return acount_numbers;
        }

        public string getType() {
            return this.account_type.ToString();
        }

    }
}

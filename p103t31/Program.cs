using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p103t31
{
    class Program
    {
        static void Get_money(BankAcount A)
        {
            Console.WriteLine("choose an action:\n0-get money\n1-pit money in ur acount");
            int action = int.Parse(Console.ReadLine());
            int count_put = 0 , count_get = 0;
            int money;
            while (action!=-1)
            {
                while (action == 1 || action == 0)
                {
                    if (action == 0)
                    {
                        Console.WriteLine("u have: " + A.Get_money() + " in your acount");
                        if (A.Get_money() > 0)
                        {
                            Console.WriteLine("write the num of money u want from ur acount");
                            money = int.Parse(Console.ReadLine());
                            while (money > A.Get_money() || money < 0)
                            {
                                Console.WriteLine("u dont have enought money or u wrote a wrong num");
                                Console.WriteLine("write the num of money u want from ur acount");
                                money = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("now u have: " + A.Less_money(money) + " money");
                            count_get = count_get + money;
                        }
                        else
                        {
                            Console.WriteLine("u dont have enought money for getting some");
                        }
                    }
                    if (action == 1)
                    {
                        Console.WriteLine("write how much money u put in ur acount");
                        money = int.Parse(Console.ReadLine());
                        Console.WriteLine("u have: " + A.More_money(money) + " in your acount");
                        count_put = count_put + money;
                    }
                    Console.WriteLine("choose an action:\n0-get money\n1-pit money in ur acount");
                    action = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("now u have: " + A.Get_money() + " money");
            Console.WriteLine("u got at all "+ count_get +"money");
            Console.WriteLine("u put at all "+ count_put +"money");
        }
        static void Main(string[] args)
        {
            //BankAcount adam = new BankAcount();
            //Get_money(adam);

            BankAcount a = new BankAcount(BankAcount.Types.JUNIOR);
            BankAcount b = new BankAcount();
            BankAcount c = new BankAcount();
            BankAcount d = new BankAcount();

            Console.WriteLine(a.getType());
        }
    }
}

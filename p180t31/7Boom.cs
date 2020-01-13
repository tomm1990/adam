using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p180t31
{
    class _7Boom
    {
        private int players;
        private int player_out;
        private int last_num;

        public _7Boom()
        {
            Console.WriteLine("pls enter how meny players");
            this.players = int.Parse(Console.ReadLine());
            this.last_num = 0;
            this.player_out = 0;
        }
        //
        public void start()
        {
            int count = 1;
            while (players>0)
            {
                Console.WriteLine("pls enter the number now");
                int num = int.Parse(Console.ReadLine());
                if (count%7==0)
                {
                    if (num % 7 == 0)
                    {
                        Console.WriteLine("Boom");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("wrong input");
                        players_less1();
                        Console.WriteLine("there are: " + this.players + " players");
                    }
                    this.last_num++;
                }
                else
                {
                    if (is_okev(num) == true)
                    {
                        Console.WriteLine("the num now is: " + num);
                        this.last_num = num;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("wrong input");
                        players_less1();
                        Console.WriteLine("there are: " + this.players + " players");
                    }
                }
                Console.WriteLine("end of the game");
            }   
        }
        //
        public void players_less1()
        {
            this.players--;
            this.player_out++;
        }
        //
        public bool is_okev(int num)
        {
            if (num == this.last_num +1)
                return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p175t4
{
    class BulPgia
    {
        private int num;
        private int guess;
        public BulPgia(int num)
        {
            if (num != 0)
            {
                this.num = num;
            }
            else
            {
                Random x = new Random();
                this.num = x.Next(1000, 10000);
            }
        }
        public void StartGame()
        {
            int i = 0;
            int count_points = 0;
            bool win = false;
            while (i<10)
            {
                Console.WriteLine("pls enter a number");
                this.guess = int.Parse(Console.ReadLine());
                if (this.guess == this.num)
                {
                    Console.WriteLine("you win");
                    win = true;
                    break;
                }
                count_points = count_points + HMPoints();
                Console.WriteLine("you got at this time: " + HMPoints() + " points");
                Console.WriteLine("you got at this time:" + GetBool() + " Buls");
                Console.WriteLine("you got at this time:" + GetPgia() + " pgiots");
                i++;
            }
            if (win == false)
            {
                Console.WriteLine("you lose");
            }
            Console.WriteLine("you got :"+ count_points+ " points");
            
        }
        public int GetNum()
        {
            return this.num;
        }
        public int GetBool()
        {
            int num = this.num;
            int guess = this.guess;
            int count =0;
            int x_num, x_guess =0 ;
            while (num > 0)
            {
                x_guess = guess % 10;
                x_num = num % 10;
                if (x_num == x_guess)
                {
                    count++;
                }
                num = num / 10;
                guess = this.guess / 10;
            }
            return count;
        }
        public int GetPgia()
        {
            int count = 0;
            int [] arr_num = FromIntToArr(this.num);
            int [] arr_guess = FromIntToArr(guess);
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i!=j)
                    {
                        if (arr_num[i] == arr_guess[j])
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        public int [] FromIntToArr(int num)
        {
            int [] arr = new int [4];
            for (int i = 0; i < 4; i++)
            {
                arr[i] = num % 10;
                num = num / 10;
            }
            return arr;
        }  
        public int HMPoints()
        {
            int bul = GetBool();
            int pgia = GetPgia();
            return bul * 2 + pgia;
        }
    }
}

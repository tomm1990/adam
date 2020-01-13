using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static public void task1()
        {
            int N;
            int count = 0;
            Random rnd = new Random();
            N = rnd.Next(1, 50);
            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    count = count + i;
                }
            }
            Console.WriteLine(count);
        }

        public static void task2_tom() {

            Console.WriteLine("Please enter price for book");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a name for book");
            string name = Console.ReadLine();

            int max_price = price,
                min_price = price;
            string max_name = name, min_name = name;

            while (price > 0)
            {

                if (price > max_price)
                {
                    max_price = price;
                    max_name = name;
                }

                if (price < min_price)
                {
                    min_price = price;
                    min_name = name;
                }

                Console.WriteLine("Please enter price for book");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a name for book");
                name = Console.ReadLine();
            }

            Console.WriteLine("Book Max:");
            Console.WriteLine("Price : " + max_price + ", Name: " + max_name);
            Console.WriteLine("Book Min:");
            Console.WriteLine("Price : " + min_price + ", Name: " + min_name);
        }

        static public void task2()
        {
            Console.WriteLine("write a name");
            string book = Console.ReadLine();
            int max = 0;
            Console.WriteLine("write a price");
            int i = 0;
            int price = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            string book_max = "";
            string book_min = "";
            while (price > 0)
            {
                Console.WriteLine("write a name");
                book = Console.ReadLine();
                Console.WriteLine("write a price");
                price = int.Parse(Console.ReadLine());
                i++;
                if (max < price)
                {
                    max = price;
                    book_max = book;
                }
                if (min > price && price > 0)
                {
                    min = price;
                    book_min = book;
                }
            }
            Console.WriteLine("book max" + book_max);
            Console.WriteLine("price:" + max);
            Console.WriteLine("book min:" + book_min);
            Console.WriteLine("price:" + min);




        }
        public static void task3()
        {
            int perfect_numbers = 0;
            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 6 == 0)
                {
                    if (digit_even(num) == true)
                    {
                        perfect_numbers++;
                    }
                }
            }

            if (perfect_numbers >= 3)
            {
                Console.WriteLine("there are more perfect");
            }
            else
            {
                Console.WriteLine("there are less perfect");
            }
        }

        public static bool digit_even(int num)
        {
            int x = num % 10;
            while (num > 0)
            {
                if (x % 2 != 0)
                {
                    return false;
                }
                num = num / 10;
                x = num % 10;
            }
            return true;
        }

        public static void task_4()
        {
            int i = int.Parse(Console.ReadLine());
            double xyzk = Double.Parse(Console.ReadLine());
            double num_1 = xyzk % 10;
            double num_2 = xyzk % 100;
            double n = num_2 - num_1;
            xyzk = xyzk - n;
            xyzk = xyzk + (i * 10);
            int ans = (int)xyzk;
            Console.WriteLine(ans);
        }

        public static void task5_tom()
        {
            double[,] mat = new double[3, 8];
            Console.WriteLine("Price:");
            double price = double.Parse(Console.ReadLine());
            while (price > 0)
            {
                Console.WriteLine("Store:");
                int store = int.Parse(Console.ReadLine());
                if (store > 0 && store < 9)
                {
                    mat[0, store - 1] += price;
                    mat[2, store - 1]++;
                    if (price > 350)
                    {
                        mat[1, store - 1]++;
                    }
                }
                Console.WriteLine("Price:");
                price = double.Parse(Console.ReadLine());
            }

            double max = double.MinValue, store_max = 0;
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                Console.WriteLine("Sum total of store {0} is {1}", i + 1, mat[0, i]);
                Console.WriteLine("Average for store {0} is {1}", i + 1, (mat[0, i] / mat[2, i]));
                Console.WriteLine("Number of sevivons for store {0} is {1}", i + 1, mat[1, i]);
                if (mat[0, i] > 50000)
                {
                    Console.WriteLine("Store number {0} is greater than 50000", i + 1);
                }
                if (mat[0, i] > max)
                {
                    max = mat[0, i];
                    store_max = i + 1;
                }
            }
            Console.WriteLine("Most sold store is store number {0}", store_max);

        }
        //
        public static void task5()
        {
            double[,] mat = new double[3, 8];
            double avrage;
            double max = 0;
            double max_store = 0;
            double buyers = 0;
            double sevivons = 0;
            double all_sevivons = 0;
            Console.WriteLine("Price:");
            int price = int.Parse(Console.ReadLine());
            double all_price = 0;
            for (int i = 0; i < 8; i++)
            {
                while (price > 0)
                {
                    all_price = all_price + price;
                    Console.WriteLine("price:");
                    price = int.Parse(Console.ReadLine());
                    buyers++;
                    if (price > 350)
                    {
                        sevivons++;
                    }
                }
                Console.WriteLine("the all price in store:" + all_price);
                all_price = mat[1, i];
                buyers = mat[2, i];
                sevivons = mat[3, i];
                avrage = all_price / buyers;
                Console.WriteLine("the avrage price in store" + i + "is:" + avrage);
                Console.WriteLine("in store" + i + "they gave" + sevivons + "sevivons");
                all_sevivons = all_sevivons + sevivons;
                if (all_price > 50000)
                {
                    Console.WriteLine("in store:" + i + "they got above 50000");
                }
                if (max < mat[1, i])
                {
                    max = mat[1, i];
                    max_store = i;
                }
            }
            Console.WriteLine("all sevivons was:" + all_sevivons);
            Console.WriteLine("the max price is in store:" + max_store);
        }
        //
        static public void task6()
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = from_int_to_arry(num);
            int hm_odd = 0;
            bool palindrom = true;
            int hm_first_num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    hm_odd++;
                }
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    palindrom = false;
                }
                if (arr[arr.Length - 1] == arr[i])
                {
                    hm_first_num++;
                }
            }
            Console.WriteLine("palindrom:" + palindrom);
            Console.WriteLine("there are:" + hm_odd + "odd num");
            Console.WriteLine("the first replayed" + hm_first_num + "times");

        }
        static public int[] from_int_to_arry(int num)
        {
            int hm_num = 0;
            int num2 = num;
            while (num > 0)
            {
                hm_num++;
                num = num / 10;
            }
            int[] arr;
            arr = new int[hm_num];
            int x;
            int place = hm_num - 1;
            while (num2 > 0)
            {
                x = num2 % 10;
                num2 = num2 / 10;
                arr[place] = x;
                place--;
            }
            return arr;
        }
        static public void task7()
        {
            for (int i = 0; i < 41; i++)
            {
                int hm_places = int.Parse(Console.ReadLine());
                int places_sold = 0;
                places_sold = places_sold + hm_places;
                while (places_sold < 301 && hm_places != 0)
                {
                    hm_places = int.Parse(Console.ReadLine());
                    if (hm_places > 300 - places_sold)
                    {
                        break;
                    }
                    places_sold = places_sold + hm_places;
                }
                Console.WriteLine(places_sold + "-places sold");
                if (places_sold < 150)
                {
                    Console.WriteLine("in show" + i + "they sold less the 150 places");
                }
                if (places_sold == 300)
                {
                    Console.WriteLine("in show" + i + "the sold all the places");
                }
            }
        }

        static public void task8()
        {
            int[,] pardes;
            pardes = new int[30, 25];
            int tree_took_less_20 = 0;
            for (int i = 0; i < pardes.GetLength(0); i++)
            {
                for (int k = 0; k < pardes.GetLength(1); k++)
                {
                    int hm_took = int.Parse(Console.ReadLine());
                    pardes[i, k] = hm_took;
                    if (hm_took > 20)
                    {
                        tree_took_less_20++;
                    }
                }
            }
            Console.WriteLine("in" + tree_took_less_20 + "they took less then 20");
            int count3 = 0;
            double avrage_in_line = 0;
            int max_orange = 0;
            int max_i_orange = 0;
            for (int i = 0; i < pardes.GetLength(0); i++)
            {
                int count2 = 0;
                for (int k = 0; k < pardes.GetLength(1); k++)
                {
                    count2 = count2 + pardes[k, i];
                    count3++;
                }
                avrage_in_line = (count2 / count3) + avrage_in_line;
                if (max_orange < count2)
                {
                    max_orange = count2;
                    max_i_orange = i;
                }
            }
            double avrage = avrage_in_line / pardes.GetLength(0);
            Console.WriteLine("in line" + max_i_orange + "they took the most oranges");
            Console.WriteLine("the avrage is:" + avrage);
        }


        static public void task9()
        {
            for (int i = 0; i < 8; i++)
            {
                bool a = true;
                int num = int.Parse(Console.ReadLine());
                int[] arr = from_int_to_arry(num);
                if (arr[0] == arr[arr.Length - 1])
                {
                    a = true;
                }
                else
                {
                    a = false;
                }
                Console.WriteLine(a);
            }
        }

        static public void task10()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int[] arr1 = from_int_to_arry(num1);
            int[] arr2 = from_int_to_arry(num2);
            int x = arr1[arr1.Length - 2];
            arr1[arr1.Length - 2] = arr2[arr2.Length - 2];
            arr2[arr2.Length - 2] = x;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            for (int k = 0; k < arr2.Length; k++)
            {
                Console.WriteLine(arr2[k]);
            }

        }

        static public int AAA(int[,] a, int i, int k, int max = 0)
        {
            for (i = 0; i < a.GetLength(1); i++)
            {
                for (k = 0; k < a.GetLength(0); k++)
                {
                    if (max < a[i, k])
                    {
                        max = a[i, k];
                    }
                }
            }
            return max;
        }
        public static void task11()
        {
            int x1, x2;
            char ch;
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            ch = char.Parse(Console.ReadLine());
            if (x1 > x2 || x2 % 2 != 0 && ch > 'b') Console.WriteLine("yes");
            else Console.WriteLine("no");
        }

        static public int test1_task2()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            if (a % 2 == 0 && b % 2 == 0)
            {
                sum = a + b;
            }
            else
            {
                sum = a * b;
            }
            return sum;
        } 

        static public void test1_task3()
        {
            int count_a = 0;
            int count_b = 0;
            int count_c = 0;
            while (count_a < 50 || count_b < 75 || count_c < 100)
            {
                int apple = int.Parse(Console.ReadLine());
                if (apple > 350 && apple < 450)
                {
                    count_a++;
                    if (count_a > 50)
                    {
                        Console.WriteLine("a - done");
                        break;
                    }
                }
                if (apple > 250 && apple < 350)
                {
                    count_b++;
                    if (count_b > 50)
                    {
                        Console.WriteLine("b - done");
                        break;
                    }
                }
                if (apple > 450 && apple < 250)
                {
                    count_c++;
                    if (count_c > 50)
                    {
                        Console.WriteLine("c - done");
                        break;
                    }
                }
            }
        }
         
        public static void test1_task4()
        {
            Console.WriteLine("enter the mikood:");
            int mikood = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the heavy:");
            double heavy = double.Parse(Console.ReadLine());
            int heavy_count = 0;
            double all_over_heavy = 0;
            double max_heavy = 0;
            int mikood_max_heavy = 0;
            double avrage = 0;
            while(mikood!=0 || heavy != 999.9)
            {
                Console.WriteLine("enter the mikood:");
                mikood = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the heavy:");
                heavy = double.Parse(Console.ReadLine()); 
                {
                    heavy_count++;
                    all_over_heavy = all_over_heavy + (heavy-10);
                }
                if (max_heavy < heavy)
                {
                    max_heavy = heavy;
                    mikood_max_heavy = mikood;
                }
            }
            avrage = all_over_heavy / heavy_count;
            Console.WriteLine("they got today:"+heavy_count*1.25+"shekels");
            Console.WriteLine("the over avrage is:"+avrage);
            Console.WriteLine("the most heavy box is for:"+mikood_max_heavy);
        }

        static void Main(string[] args)
        {

            //task1();
            //            task2();
            //task2_tom();
            //task3();
            //task3();
            //task5();
            //task5_tom();
            //task6(); 
            //task7();
            //task8();
            //task9();
            //task10();
            //task11();
            //int num;
            //bool b;
            //test1_task2();
            //test1_task3();
            test1_task4();


        }
    }

    }


using System;

namespace _0314
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, n, j, sum;
            string[] name =new string[6]{ "", "凱翔", "柏豪", "嘉昇", "偉智", "頎崴" };
            int[] score1 = new int[6] { 0, 59, 55, 87, 78, 38 };
            int[] score2 = new int[6] { 0, 50, 28, 56, 31, 38 };
            int[] score3 = new int[6] { 0, 69, 30, 70, 58, 38 };

            Console.WriteLine("請輸入一個數字");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 != 0)
            {
                Console.WriteLine("Odd Wried");
            }
            else if (num < 5)
            {
                Console.WriteLine("even Not Wried");
            }
            else if (num <= 20)
            {
                Console.WriteLine("even Wried");
            }

            Console.WriteLine("請輸入迴圈數");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {

                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("請輸入迴圈數");
            n = Convert.ToInt32(Console.ReadLine());


            for (i = 1; i <= n; i++)
            {
                sum = n * i;
                Console.Write(n + "*" + i + "=" + sum);
                Console.Write("\n");
            }

            for (i = 1; i <= 9; i++)
            {

                for (j = 1; j <= 9; j++)
                {
                    sum = i * j;
                    Console.Write(i + "*" + j + "=" + sum + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("請輸入座號");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(name[n]);
            Console.Write("數學" + score1[n]);
            Console.Write("國文" + score2[n]);
            Console.Write("健康" + score3[n]);


        }
    }
}

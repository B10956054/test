using System;

namespace _0314
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i;
            Console.WriteLine("請輸入一個數字");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 != 0 )
            {
                Console.WriteLine("Odd Wried");
            }
            else if(num < 5 )
            {
                Console.WriteLine("even Not Wried");
            }
            else if(num <= 20)
            {
                Console.WriteLine("even Wried");
            }

            for(i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }   


        }
    }
}

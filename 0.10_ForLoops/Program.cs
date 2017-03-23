using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int lcv = 0; lcv < 80; lcv += 1)
            //{
            //    Console.WriteLine("Shelby is the coolest ever");
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine("No");
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            int sum = 0;
            for (int i = 0; i<=10; i++)
            {
                sum = sum + i;
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

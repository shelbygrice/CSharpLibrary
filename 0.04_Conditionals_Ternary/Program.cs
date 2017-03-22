using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 7;

            Console.WriteLine((age == 7) ? "true" : "false");
            Console.ReadLine();


            int num = 10;
            if (num == 7)
                Console.WriteLine("This is the number 7");
            else
                Console.WriteLine("This number isn't 7");
        }
    }
}

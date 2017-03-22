using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if (feelingNumber == "5")
            {
                Console.WriteLine("Wow man. That's great to hear.");
            }
            else if (feelingNumber == "4")
            {
                Console.WriteLine("What can I do to help make your day better?");
            }
            else if (feelingNumber == "3")
            {
                Console.WriteLine("Meh. We've all been there.");
            }
            else if (feelingNumber == "2")
            {
                Console.WriteLine("Well, it could be worse buddy.");
            }
            else if (feelingNumber == "1")
            {
                Console.WriteLine("Yikes. Sorry to hear that.");
            }
            else if (feelingNumber == "6")
            {
                Console.WriteLine("Shut up. No one can be that happy.");
            }
            else
            {
                Console.WriteLine("We gave you specific parameters to follow. Don't try to get smart and just follow the rules.");
            }




            Console.ReadLine();
        }
    }
}

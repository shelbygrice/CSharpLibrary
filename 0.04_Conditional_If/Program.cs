using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_If
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isOn = true;
            //bool isHot = false;

            //if (isOn)
            //{
            //    Console.WriteLine("The light is on. It's bright.");
            //}

            //Console.ReadLine();

            ////2
            //if (isOn == true)
            //{
            //    Console.WriteLine("The light is on");
            //}
            //if (isOn && isHot)
            //{
            //    Console.WriteLine("Lights on and it's hot");
            //}
            //if (isOn || isHot)
            //{
            //    Console.WriteLine("lights on or it is hot");
            //}
            //if (!isHot)
            //{
            //    Console.WriteLine("It is not hot");
            //}





            bool isAdmin = true;
            bool isLoggedIn = true;

            if (isAdmin)
            {
                Console.WriteLine("Welcome to the site Admin");
            }
            
            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back");
            }
            if (isAdmin && isLoggedIn)
            {
                Console.WriteLine("You're logged in! And you're an Admin.");
            }

            Console.ReadLine();
        }
    }
}

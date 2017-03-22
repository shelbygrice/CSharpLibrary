using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = false;
            bool elevatorDown = false;
            bool elevatorBroken = true;
            bool elevatorStuckWhileWeAreOnIt = true;
            int floorNumber = 13;

            if(elevatorUp == true)
            {
                Console.WriteLine("Going up");
            }
            else
            {
                Console.WriteLine("Going down");
            }
            if (elevatorBroken)
            {
                Console.WriteLine("Bummer. Let's take the stairs.");
            }
            else
            {
                Console.WriteLine("Which floor?");
            }
            if (elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("Yeah! Let's go DieHard in this elevator shaft!!!");
            }
            else
            {
                Console.WriteLine("Do you have those TPS reports for me?");
            }
            if (elevatorBroken && elevatorDown)
            {
                Console.WriteLine("Not again...");
            }
            else
            {
                Console.WriteLine("Man, I wish this thing was broken. That would be cool.");
            }
            if (elevatorBroken || elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("Dude, we're in Mexico. We're in 4th grade. We're stuck on an elevator.");
            }
            if (floorNumber == 13)
            {
                Console.WriteLine("I'm really scared that Freddy Krueger is going to rip through the ceiling and kill us.");
            }
            if (floorNumber == 13 && elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("It's just not your day , is it buddy.");
            }
            Console.ReadLine();
        }
    }
}

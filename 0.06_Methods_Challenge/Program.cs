using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix parksAndRecreation = new Netflix();
            parksAndRecreation.Name = "Parks and Recreation";
            parksAndRecreation.Rating = 4.9m;
            parksAndRecreation.Genre = "Comedy";
            parksAndRecreation.TotalMinutes = 22;
           

            parksAndRecreation.ShowMinutesLeft(22, 17);

            Netflix theOffice = new Netflix();
            theOffice.Name = "The Office";
            theOffice.Rating = 5.0m;
            theOffice.Genre = "Comedy";

            Netflix bobsBurgers = new Netflix();
            bobsBurgers.Name = "Bob's Burgers";
            bobsBurgers.Rating = 3.7m;
            bobsBurgers.Genre = "Cartoon Comedy";

            //parksAndRecreation.GetSuggestion();
            //theOffice.GetSuggestion();
            //bobsBurgers.GetSuggestion();

            //parksAndRecreation.ShowRunTime();
            //parksAndRecreation.WhoWatched("Shelby", "10;:30");


            Console.ReadLine();
        }
    }
}

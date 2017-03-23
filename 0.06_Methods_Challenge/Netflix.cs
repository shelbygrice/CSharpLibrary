using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods_Challenge
{
    class Netflix
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public decimal Rating { get; set; }
        public int TotalMinutes { get; set; }

        public void GetSuggestion()
        {
            if (this.Rating >= 4)
            {
                Console.WriteLine("You should definitely watch this show.");
            }
            else
            {
                Console.WriteLine("You probably won't want to watch this show.");
            }

        
        }
        ///<summary>
        ///Methods that return a value
        ///</summary>
        
        public int ShowRunTime()
        {
            Console.WriteLine(this.TotalMinutes);
            return this.TotalMinutes;

        }

        ///METHODS that have parameters
        
        public string WhoWatched(string username, string time)
        {
            string details = username + " watched this at " + time;
            Console.WriteLine(details);
            return details;
            
        }

        public int ShowMinutesLeft(int TotalMinutes, int MinutesWatched)
        {
            int MinutesLeft = this.TotalMinutes - MinutesWatched;
            Console.WriteLine("You have watched {0} minutes and have {1} minutes left. Continue?", MinutesWatched, MinutesLeft);
            return MinutesLeft;
        }
        






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Collections_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary.Add("cat", "an annoying creature");
            //dictionary.Add("dog", "man's best friend");

            //foreach(KeyValuePair<string, string> pair in dictionary)
            //{
            //    Console.WriteLine("The {0} is {1}", pair.Key, pair.Value);

            //}


            Dictionary<string, string> bestPictureWinners = new Dictionary<string, string>();
            bestPictureWinners.Add("2000", "Gladiator");
            bestPictureWinners.Add("2001", "A Beautiful Mind");
            bestPictureWinners.Add("2002", "Chicago");
            bestPictureWinners.Add("2003", "The Lord of the Rings: The Return of the King");
            bestPictureWinners.Add("2004", "Million Dollar Baby");
            bestPictureWinners.Add("2005", "Crash");

            foreach (KeyValuePair<string, string> pair in bestPictureWinners)
            {
                Console.WriteLine("The winner of the Academy Award for Best Picture in {0} was {1}.", pair.Key, pair.Value);
            }


            Dictionary<string, string[]> bestPictureNoms = new Dictionary<string, string[]>();
            bestPictureNoms.Add("2000", new string[] { "Gladiator", "Chocolat", "Crouching Tiger, Hidden Dragon", "Erin Brockovich", "Traffic" });
            bestPictureNoms.Add("2001", new string[] { "A Beautiful Mind", "Gosford Park", "In the Bedroom", "The Lord of the Rings: The Fellowship of the Ring", "Moulin Rouge!" });
            bestPictureNoms.Add("2002", new string[] { "Chicago", "Gangs of New York", "The Hours", "The Lord of the Rings: The Two Towers", "The Pianist" });
            bestPictureNoms.Add("2003", new string[] { "The Lord of the Rings: The Return of the King", "Lost in Translation", "Master and Commander: The Far Side of the World", "Mystic River", "Seabiscuit" });
            bestPictureNoms.Add("2004", new string[] { "Million Dollar Baby", "The Aviator", "Finding Neverland", "Ray", "Sideways" });
            bestPictureNoms.Add("2005", new string[] { "Crash", "Brokeback Mountain", "Capote", "Good Night, and Good Luck", "Munich" });

            foreach (KeyValuePair<string, string[]> bestPictureNom in bestPictureNoms)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}, {4}, {5}", bestPictureNom.Key, bestPictureNom.Value[0], bestPictureNom.Value[1], bestPictureNom.Value[2], bestPictureNom.Value[3], bestPictureNom.Value[4]);
            }

            Console.WriteLine("Please type a year to show the movie that won:");
            string input1 = Console.ReadLine();

            if(bestPictureWinners.ContainsKey(input1))
            {
                string valueForKey = bestPictureWinners[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + valueForKey);
            }


            Console.WriteLine("Please type the year to show the movies that were up for the Best Picture award: ");
            string input2 = Console.ReadLine();

            if (bestPictureNoms.ContainsKey(input2))
            {
                string[] valueForKey = bestPictureNoms[input2];
                string nomineeString = string.Join(", ", valueForKey);
                Console.WriteLine("The nominees for Best Picture in " + input2 + " were " + nomineeString);

            }

            Console.ReadLine();
        }
    }
}

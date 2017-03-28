using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_New_Console_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Survive High School");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your stereotype?");
            Console.WriteLine("What is your player type?\n" +
                                "0: Athlete\n" +
                                "1: Nerd\n" +
                                "2: Stoner\n" +
                                "3: Musician\n" +
                                "4: Popular\n" +
                                "5: Artist");

            int playerType = int.Parse(Console.ReadLine());

            Player player = new Player(name);
            player.ChooseType(playerType);

            Console.WriteLine("Welcome to high school, {0}. Good luck, you'll need it.", name);

            player.PrintCurrentStatus();

            Console.WriteLine("You forgot to do your homework for English class and you don't have time to do it before. What do you do?\n" +
                                "0: Admit you forgot to do it\n" +
                                "1: Lie and say you did it, but that you forgot it at home\n" +
                                "2: Hide in the bathroom until class is over\n");
            string homework = Console.ReadLine();
            if (homework == "0")
            {
                Console.WriteLine("You get a zero on your first assignment of the year. Lose 20 grade points.");
                player.Grades -= 20;
            }
            else if (homework == "1")
            {
                Console.WriteLine("The teacher seems suspicious, but lets you turn it in late. Lose 10 grade points.");
                player.Grades -= 10;
            }
            else if (homework == "2")
            {
                Console.WriteLine("You miss class and have an extra night to do the homework. You maintain your grades.");
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand the command.");
            };
            player.PrintCurrentStatus();

            Console.WriteLine("You are asked to the Homecoming dance by someone you don't want to go with. How do you respond?\n" +
                                "0: Say you're busy the night of Homecoming\n" +
                                "1: Agree, because you would feel bad about saying no\n" +
                                "2: Say no, and tell them you would rather go alone\n");
            string hocoDance = Console.ReadLine();
            if (hocoDance == "0")
            {
                Console.WriteLine("You stay home from Homecoming, but miss out on the fun. Lose 20 happiness points.");
                player.Happiness -= 20;
            }
            else if (hocoDance == "1")
            {
                Console.WriteLine("You had to hang out with them all night instead of your friends. Lose 10 happiness points.");
                player.Happiness -= 10;
            }
            else if (hocoDance == "2")
            {
                Console.WriteLine("You feel bad for them, but you have fun with your friends at Homecoming. You maintain your happiness.");
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand the command.");
            };
            player.PrintCurrentStatus();

            Console.WriteLine("Someone had a party after a football game, and somehow you got roped into going. What do you do?\n" +
                                "0: TEQUILA SHOTS\n" +
                                "1: Join the people smoking upstairs\n" +
                                "2: Leave early because parties don't interest you\n");
            string party = Console.ReadLine();
            if (party == "0")
            {
                Console.WriteLine("You don't remember much of the night or how you got home, but you know you had a good time based on the hangover. Lose 30 health points.");
                player.Health -= 30;
            }
            else if (party == "1")
            {
                Console.WriteLine("Whatever you were smoking was good stuff. Gain 10 happiness points.");
                player.Happiness += 10;
            }
            else if (party == "2")
            {
                Console.WriteLine("You go home and do homework, like a loser. Gain 10 grade points.");
                player.Grades += 10;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand the command.");
            };
            player.PrintCurrentStatus();


            Console.ReadLine();
        }
    }
}

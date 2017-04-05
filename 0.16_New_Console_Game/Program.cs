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
                                "5: Artist\n");

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
                                "1: Volunteer yourself to be a designated driver\n" +
                                "2: Leave early because parties don't interest you\n");
            string party = Console.ReadLine();
            if (party == "0")
            {
                Console.WriteLine("You don't remember much of the night or how you got home, but you know you had a good time based on the hangover. Lose 30 health points.");
                player.Health -= 30;
            }
            else if (party == "1")
            {
                Console.WriteLine("You are able to watch your drunk friends make fools of themselves AND make sure they get home safely. Gain 10 happiness points.");
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

            Console.WriteLine("Your mom gives you twenty bucks for gas. What do you spend it on?\n" +
                                "0: Gas, obviously.\n" +
                                "1: Buy something else you want, because you don't need gas THAT much.\n" +
                                "2: Save it for a later date.\n");
            string gasMoney = Console.ReadLine();
            if (gasMoney == "0")
            {
                Console.WriteLine("You have enough gas now to go hang out with your friend. Gain 10 happiness points.");
                player.Happiness += 10;
            }
            else if (gasMoney == "1")
            {
                Console.WriteLine("Shockingly, you run out of gas sooner rather than later, and your mom is very angry when she has to come get you. Lose 20 health and 10 happiness points. ");
                player.Happiness -= 10; player.Health -= 20;
            }
            else if (gasMoney == "2")
            {
                Console.WriteLine("Grades aren't really affected by gas money, but you seem smart so you gain 10 grade points.");
                player.Grades += 10;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand the command.");
            };
            player.PrintCurrentStatus();

            Console.WriteLine("You have chemistry homework, English homework, and algebra homework, all in the same night. With your extracurriculars and dinner, this homework could take all night. What do you do?\n" +
                                "0: Do all the homework, no matter how long it takes.\n" +
                                "1: Do as much homework as you can, but don't give up on any sleep.\n" +
                                "2: Become too overwhelmed by how much you need to do that you don't do any of it and take a nap instead.\n");
            string tooMuchHomework = Console.ReadLine();
            if (tooMuchHomework == "0")
            {
                Console.WriteLine("Your homework gets done, but your sleep schedule suffers. Lose 15 health points.");
                player.Health -= 15;
            }
            else if (tooMuchHomework == "1")
            {
                Console.WriteLine("You don't get all of your homework done, but you get a decent amount of sleep, so that's something. Lose 10 grade points.");
                player.Grades -= 10;
            }
            else if (tooMuchHomework == "2")
            {
                Console.WriteLine("You are the worst, and nothing gets done. Lose 20 grade points, but gain 5 happiness points.");
                player.Grades -= 20; player.Happiness += 5;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand the command.");
            };
            player.PrintCurrentStatus();
            Console.WriteLine("Somehow all your friends are sick on the same day, so your lunch table is empty. What do you do?\n" +
                                "0: Find a group that seems friendly and sit with them.\n" +
                                "1: Sit at your regular table, even if nobody else is there.\n" +
                                "2: Eat in the bathroom. You've seen it happen in movies and TV shows, so people MUST do it, right?\n");
            string lunch = Console.ReadLine();
            if (lunch == "0")
            {
                Console.WriteLine("You sit at another table, but you feel left out of the conversation. Lose 10 happiness points.");
                player.Happiness -= 10;
            }
            else if (lunch == "1")
            {
                Console.WriteLine("You take this time to do homework that never got done. Gain 5 grade points.");
                player.Grades += 5;
            }
            else if (lunch == "2")
            {
                Console.WriteLine("That wasn't sanitary, and you get sick. Lose 15 health points.");
                player.Health -= 15;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand the command.");
            };
            player.PrintCurrentStatus();
            Console.WriteLine("You get to choose your electives. What elective do you choose?\n" +
                                "0: Gym\n" +
                                "1: \n" +
                                "2: \n");
            string elective = Console.ReadLine();
            if (elective == "0")
            {
                Console.WriteLine("You become stronger and healthier over the course of the semester. Gain 10 health points.");
                player.Health += 10;
            }
            else if (elective == "1")
            {
                Console.WriteLine("");
                player.Grades += 5;
            }
            else if (elective == "2")
            {
                Console.WriteLine("");
                player.Health -= 15;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand the command.");
            };
            player.PrintCurrentStatus();

            player.PrintCurrentStatus();
            if (player.Grades <= 0)
            {
                Console.WriteLine("You flunked out of high school, got kicked out of your house, and died out on the streets. You lost. Try not to die next time!");
                
            }
            else if (player.Health <= 0)
            {
                Console.WriteLine("Your health was so low that you died. You lost. Try not to die next time!");
                
            }
            else if (player.Happiness <= 0)
            {
                Console.WriteLine("Your happiness was so low, you killed yourself. You lost. Try not to die next time!");
                
            }
            else
            {
                Console.WriteLine("You won! Congratulations! You didn't peak in high school!");
                
            };
            Console.ReadLine();
        }
    }
}

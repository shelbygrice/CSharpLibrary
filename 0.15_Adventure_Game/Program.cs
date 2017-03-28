using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What clan are you apart of?");
            string clan = Console.ReadLine();
            Console.WriteLine("What is your player type?\n" +
                                "0: Assassin\n" +
                                "1: Blitzen Blopper\n" +
                                "2: Professor\n" +
                                "3: Horse Mange\n" +
                                "4: Tax Man\n" +
                                "5: Human");

            int playerType = int.Parse(Console.ReadLine());

            Player player = new Player(name, clan);
            player.ChooseType(playerType);

            Console.WriteLine(player.ToString());
            
            player.PowerLevelCheck();
            player.BattleCry();

            Troll troll = new Troll();
            while (true)
            {
                Console.WriteLine("Do you want to continue? y/n");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "y")
                {
                    troll.TrollAttack(player);
                    if (player.CurrentPower <= 0 )
                    {
                        Console.WriteLine("Sorry, you died. Tough loss.");
                        break;
                    }
                }
                else
                {
                    break;
                }
                break;
            }
           
            troll.TrollAttack(player);

            Console.WriteLine(player.CurrentPower);
            Console.WriteLine("This is a new attack");

            troll.TrollAttack(player);

            Console.ReadLine();
        }
    }
}

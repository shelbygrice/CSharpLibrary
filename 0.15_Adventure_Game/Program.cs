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

            troll.Insult();
            //Enemy quagga = new Enemy();

            
            
            //quagga.Insult();
            
            Console.ReadLine();
        }
    }
}

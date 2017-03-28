using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Adventure_Game
{
    class Troll : Enemy
    {

        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Confusing Riddle", 5 },
                {"Body Slam", 15 },
                {"Wooden Club", 20 }
            };

        public Troll()
        {
            this.Name = "Bridge Troll";
            this.PowerLevel = 35;
        }

        public void TrollAttack()
        {
            Console.WriteLine("Uh oh! You've come to a bridge guarded by a Troll!\n");
            
        }

        public override void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("{0} You can't go on this bridge!", insult[r]);
        }

        public void TrollAttack(Player player)
        {
            Attack(player, Attacks, this.Name);
        }
    }
}

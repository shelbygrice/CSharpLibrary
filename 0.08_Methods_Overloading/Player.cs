using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Player
    {
        public string PlayerName { get; set; }


        //Attack X 3

        public void Attack()
        {
            Console.WriteLine("The player attacked for 5 points");
        }
        public void Attack(string weapon)
        {
            Console.WriteLine("The player attacked with the rusty " + weapon);
        }
        public void Attack(string weapon, int attackPoints)
        {
            Console.WriteLine("The player attacked with the rusty " + weapon + " for " + attackPoints);
        }
        public void Attack(string PlayerName, string weapon, int attackPoints)
        {
            Console.WriteLine("{0} attacked with the rusty {1} for {2} points.", PlayerName, weapon, attackPoints);
        }
    }
}

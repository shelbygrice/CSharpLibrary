﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Adventure_Game
{
    abstract class Enemy
    {
        protected ArrayList insult = new ArrayList { "Your mother was a hamster and your father smelt of elderberries.", "I fart in your general direction.", "I blow my nose at you.", "You empty-headed animal food trough whopper.", "You cheesy load of secondhand electric donkey bottom biters!", " I’ll wave my private parts at your aunties!" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }


        public virtual void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("{0}", insult[r]);
        }

        public void Attack(Player player, Dictionary<string, int> dict, Object enemyName)
        {
            Console.WriteLine("{0}'s power is at {1}%", player.PlayerName, player.CurrentPower);

            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;
            Console.WriteLine("Enemy attacked using {0} for {1} damage.", attackName, attackVal);
            player.CurrentPower -= attackVal; //player.CurrentPower = player.CurrentPower - attackVal

        }
        
    }
}

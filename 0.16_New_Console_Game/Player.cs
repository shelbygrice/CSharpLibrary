using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_New_Console_Game
{
    public enum CharacterType
    {
        Athlete = 0,
        Nerd = 1,
        Stoner = 2,
        Musician = 3,
        Popular = 4,
        Artist = 5
    }
    class Player
    {
        public string PlayerName { get; set; }
        public int Happiness { get; set; }
        public int Grades { get; set; }
        public int Health { get; set; }
        public CharacterType Type { get; set; }

        public Player(string name, CharacterType type = CharacterType.Nerd)
        {
            this.PlayerName = name;
            this.Happiness = 100;
            this.Grades = 100;
            this.Health = 100;
            this.Type = type;
        }

        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 0:
                    Console.WriteLine("You are an Athlete.");
                    return this.Type = CharacterType.Athlete;
                case 1:
                    Console.WriteLine("You are a Nerd.");
                    return this.Type = CharacterType.Nerd;
                case 2:
                    Console.WriteLine("You are a Stoner.");
                    return this.Type = CharacterType.Stoner;
                case 3:
                    Console.WriteLine("You are Musician");
                    return this.Type = CharacterType.Musician;
                case 4:
                    Console.WriteLine("You are Popular");
                    return this.Type = CharacterType.Popular;
                case 5:
                    Console.WriteLine("You are an Artist");
                    return this.Type = CharacterType.Artist;
                default:
                    Console.WriteLine("You are a Nerd");
                    return this.Type = CharacterType.Nerd;
            }
        }

        public void PrintCurrentStatus()
        {
            Console.WriteLine("Happiness: {0}\nGrades: {1}\nHealth: {2}", Happiness, Grades, Health);
        }
    }
}

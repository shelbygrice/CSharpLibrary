using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Inheritance
{
    class Dog : Animal
    {
        public bool IsAGoodBoy { get; set; }
        public string Breed { get; set; }
        public bool Stray { get; set; }

        public void Beg()
        {
            Console.WriteLine("Please pet me!!!!!!!!!!!!!!");
        }

        public void Speak()
        {
            Console.WriteLine("I am a good boy!!!!!!!!!!!!!!!");
        }

        


    }
}

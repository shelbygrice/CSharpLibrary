using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bear barryTheBear = new Bear();
            //barryTheBear.Weight = 2000;

            //barryTheBear.Walks();
            //barryTheBear.Speak();

            //Console.ReadLine();


            Dog airBud = new Dog();
            airBud.IsAGoodBoy = true;
            airBud.Weight = 44;
            airBud.HasEyes = true;


            airBud.Beg();

            PolarBear cokeACola = new PolarBear();
            Animal theJSWizard = new Animal();
            theJSWizard.NumberOfLegs = 2;
            theJSWizard.HasEyes = false;

            Console.ReadLine();
        }
    }
}

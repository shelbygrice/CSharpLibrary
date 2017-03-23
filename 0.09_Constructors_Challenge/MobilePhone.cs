using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenge
{
    class MobilePhone
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public MobilePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public void PrintToScreen()
        {
            Console.WriteLine("I own an " + Make + " " + Model);
            Console.ReadLine();

        }
    }
}

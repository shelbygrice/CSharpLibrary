﻿Name,using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Inheritance
{
    class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HasEyes { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }
        public string Sound { get; set; }


        public void Walks()
        {
            Console.WriteLine("I just took four steps");
        }
    }
}

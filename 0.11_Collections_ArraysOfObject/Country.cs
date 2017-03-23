using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Collections_ArraysOfObject
{
    class Country
    {
        //Constructors
        public Country(string name, string capital)
        {
            this.Name = name;
            this.Capital = capital;
        }

        //Properties
        public string Name { get; set; }
        public string Capital { get; set; }

        //Method
        public void PrintCountryDetails()
        {
            Console.WriteLine("The caputal of {0} is {1}", Name, Capital);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Base
{
    class Minor : Person
    {
        public Minor(string firstName, string lastName) : base(firstName, lastName)
        {
            
        }

        public Minor(string firstName, string lastName, bool IsInSchool) : base(firstName, lastName)
        {

        }

        public bool IsInSchool { get; set; }

        public void DemoMethod()
        {
            Console.WriteLine("Demo method in Minor class");
        }

    }
}

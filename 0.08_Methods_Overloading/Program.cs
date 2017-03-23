using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player theJSWizard = new Player();
            theJSWizard.PlayerName = "The JS Wizard";
            theJSWizard.Attack();
            theJSWizard.Attack("hard drive");
            theJSWizard.Attack("hard drive", 2);
            theJSWizard.Attack("The JS Wizard", "hard drive", 2);

            Console.ReadLine();
        }
    }
}

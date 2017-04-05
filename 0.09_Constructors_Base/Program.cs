using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Person chris = new Person("Chris", "Sullivan");
            chris.Method();

            Minor sophie = new Minor("Sophia", "O'Connor", true);
            sophie.DemoMethod();

            Person kenn = new Minor("Kenn", "Pascascio", true);
            kenn.Method();

        }
        
    }
}

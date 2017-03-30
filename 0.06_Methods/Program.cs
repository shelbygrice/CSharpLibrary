
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer theJSWizard = new Customer();
            theJSWizard.AppearsWealthy = false;
            theJSWizard.FirstName = "James";
            theJSWizard.LastName = "Handshoe";

            theJSWizard.PrintCustomerName();

            Customer theSheriff = new Customer();
            theSheriff.FirstName = "Sheriff";
            theSheriff.LastName = "Holler";
            theSheriff.PrintCustomerName();

            Customer mom = new Customer();
            mom.FirstName = "Julie";
            mom.LastName = "Grice";
            mom.PrintCustomerName();

            Console.ReadLine();
        }
    }
}

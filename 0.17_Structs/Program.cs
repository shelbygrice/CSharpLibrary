using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry paul = new AddressBookEntry()
            {
                Address = "123 Coder ln",
                City = "Westfield",
                State = "IN",
                Zip = "44056",
                FirstName = "Paul",
                LastName = "O'Connor",
                Age = 40
            };

            AddressBookEntry dave = new AddressBookEntry()
            {
                Address = "113 Hunter pl",
                City = "Indianapolis",
                State = "IN",
                Zip = "46202",
                FirstName = "Dave",
                LastName = "Brown",
                Age = 53
            };

            AddressBookEntry phil = new AddressBookEntry()
            {
                Address = "7934 Middlebrook ave",
                City = "Zionsville",
                State = "IN",
                Zip = "46019",
                FirstName = "Phil",
                LastName = "Jones",
                Age = 34
            };

            AddressBookEntry chuck = new AddressBookEntry()
            {
                Address = "9024 E Main St",
                City = "Whitestown",
                State = "IN",
                Zip = "46075",
                FirstName = "Chuck",
                LastName = "Nelson",
                Age = 48
            };

            Console.WriteLine(paul.GetAddress());
            Console.WriteLine(paul.GetDetails());
            Console.ReadLine();
        }
        struct AddressBookEntry
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public string Address;
            public string City;
            public string State;
            public string Zip;

            

            public string GetAddress()
            {
                return $"Address: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}";
            }
            public string GetDetails()
            {
                return $"{FirstName} {LastName}: {Age} years old";
            }
        }
    }
}

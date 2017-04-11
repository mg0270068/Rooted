using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooted
{
    class Entry
    {
        //base information data
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        string zip;
        double initialSale;
        double tax;
        double finalSale;


        //public entry class for access by other sections of the program
        public Entry(string fname, string lname, string add, string ct, string st, string zp, double initsale, double tx, double fsale)
        {
            FirstName = fname;
            LastName = lname;
            Address = add;
            City = ct;
            State = st;
            Zip = zp;
            InitialSale = initsale;
            Tax = tx;
            FinalSale = fsale;
        }

        //just in case
        public override string ToString()
        {
            return firstName + " " + lastName + ", " + "at " + address + " " + city + ", " + state + " " + zip + "\nInitial Sale: " + initialSale + "\nTax: " + tax + "\nFinal Sale: " + finalSale;
        }

        //TODO: figure out what data we're sending to QuickBooks, then implement this method to send variables where necessary
        public virtual string SendData()
        {
            //temporarily returns an empty string
            return "";
        }

        //getters and setters go here
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }

            set
            {
                zip = value;
            }
        }

        public double InitialSale
        {
            get
            {
                return initialSale;
            }

            set
            {
                initialSale = value;
            }
        }

        public double Tax
        {
            get
            {
                return tax;
            }

            set
            {
                tax = value;
            }
        }

        public double FinalSale
        {
            get
            {
                return finalSale;
            }

            set
            {
                finalSale = value;
            }
        }

    }
}

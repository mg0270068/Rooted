using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooted
{
     public class Entry
    {
        //base information data
        string firstName;
        string lastName;
        string address;
        string phoneNumber;
        string city;
        string state;
        string zip;
        double initialSale;
        double tax;
        double finalSale;
        bool isDeceased = false;

        //first constructor; will pass this entry into the finalized entry
        public Entry(string fname, string lname, string add, string phone, string ct, string st, string zp)
        {
            FirstName = fname;
            LastName = lname;
            Address = add;
            PhoneNumber = phone;
            City = ct;
            State = st;
            Zip = zp;
        }

        //overloaded constructor with extra boolean for deceased check; used with delivery information
        public Entry(string fname, string lname, string add, string phone, string ct, string st, string zp, bool isdec)
        {
            FirstName = fname;
            LastName = lname;
            Address = add;
            PhoneNumber = phone;
            City = ct;
            State = st;
            Zip = zp;
            IsDeceased = isdec;
        }

        //overloaded constructor for use with final page
        public Entry(string fname, string lname, string add, string phone, string ct, string st, string zp, double initsale, double tx, double fsale)
        {
            FirstName = fname;
            LastName = lname;
            Address = add;
            PhoneNumber = phone;
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
            return firstName + " " + lastName + ", " + "at " + address + " " + city + ", " + state + " " + zip + "with phone number " + phoneNumber/*+ "\nInitial Sale: " + initialSale + "\nTax: " + tax + "\nFinal Sale: " + finalSale*/;
        }

        //send entry class to necessary location in code
        /*public virtual Entry SendEntry(Entry entry)
        {
            initEntry = entry;
            Console.WriteLine(initEntry.ToString());
            return entry;
        }*/

       /* public virtual Entry ReceiveEntry()
        {
            return initEntry;
        }*/

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

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public bool IsDeceased
        {
            get
            {
                return isDeceased;
            }

            set
            {
                isDeceased = value;
            }
        }
    }
}



//TODO: Copy this into a final submission form

    

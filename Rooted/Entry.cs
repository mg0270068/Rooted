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
			return base.ToString();
		}

		//TODO: figure out what data we're sending to QuickBooks, then implement this method to send variables where necessary
		public virtual string SendData()
		{
			//temporarily returns an empty string
			return "";
		}

		//getters and setters go here
		public string FirstName { get => firstName; set => firstName = value; }
		public string LastName { get => lastName; set => lastName = value; }
		public string Address { get => address; set => address = value; }
		public string City { get => city; set => city = value; }
		public string State { get => state; set => state = value; }
		public string Zip { get => zip; set => zip = value; }
		public double InitialSale { get => initialSale; set => initialSale = value; }
		public double Tax { get => tax; set => tax = value; }
		public double FinalSale { get => finalSale; set => finalSale = value; }
	}
}

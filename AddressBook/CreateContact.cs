using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contacts
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipcode;
        public long phoneNumber;
        public string email;

        public Contacts(string firstName, string lastName, string address, string city, string state, int zipcode, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public static void CreateContacts()
        {
            Console.WriteLine("Enter First Name:-");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:-");
            string secondName = Console.ReadLine();
            Console.WriteLine("Enter Address:-");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City:-");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State:-");
            string state = Console.ReadLine();
            Console.WriteLine("Enter ZipCode:-");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number:-");
            long phoneNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email Id:-");
            string email = Console.ReadLine();
            Console.WriteLine("Contact has been Created..!!");
        }
    }
}

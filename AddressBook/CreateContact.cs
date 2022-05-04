using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipcode;
        public long phoneNumber;
        public string email;

        public Contact(string firstName, string lastName, string address, string city, string state, int zipcode, long phoneNumber, string email)
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
       

        // Add New Contact Details
        public static void AddNewContact()
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
            int zipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number:-");
            long phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email Id:-");
            string email = Console.ReadLine();
            Console.WriteLine("Contact has been Added");
        }
    }


}

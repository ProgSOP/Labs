using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace semestr_2__Laba4_task2_
{
    internal class Customers
    {
        private int _id;
        private string _lastName;
        private string _firstName;
        private string _phoneNumber;
        private Tariffs _tariff;
        

        public Customers(int id,string lastName,string firstName,string phoneNumber, Tariffs tariff)
        {
            _id = id;
            _lastName = lastName;
            _firstName = firstName;
            PhoneNumber = phoneNumber;
            _tariff = tariff;
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set {
                if (value.StartsWith("+380"))
                {
                    _phoneNumber = value;
                }
                else
                {
                    _phoneNumber = "Unknown phone number";
                }
            }
        }

        public void WriteCustomers()
        {
            Console.WriteLine("Customer: ");
            Console.WriteLine($"Customer Id: {_id}");
            Console.WriteLine($"Customer name: {_lastName} {_firstName}");
            Console.WriteLine($"Customer Phone: {_phoneNumber}");
            Console.WriteLine($"Customer tarif: {_tariff.Name}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final
{
    public class ClassCustomer
    {

        public ClassCustomer(int id, String firstName, String lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public ClassCustomer(String firstName, String lastName, String address, String city, String state, String zipCode, String phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            Phone = phone;
        }

        public ClassCustomer(int id, String firstName, String lastName, String address, String city, String state, String zipCode, String phone)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            Phone = phone;
        }

        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String ZipCode { get; set; }
        public String Phone { get; set; }

    }
}
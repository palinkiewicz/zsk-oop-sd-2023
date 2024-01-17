using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja2_Dziedziczenie.classes
{
    internal class Address
    {
        public string City;
        public string Street;
        public int HouseNumber;
        public string PostalCode;

        public Address(string city, string street, int houseNumber, string postalCode)
        {
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
        }
    }
}

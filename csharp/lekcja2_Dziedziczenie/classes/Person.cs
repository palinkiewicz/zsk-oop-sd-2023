using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja2_Dziedziczenie.classes
{
    internal class Person(string name, string surname, DateTime dateOfBirth, Address address)
    {
        public string Name = name;
        public string Surname = surname;
        public DateTime DateOfBirth = dateOfBirth;
        public Address Address = address;

        public int Age {
            get { return (int)(DateTime.Now - DateOfBirth).TotalDays / 365; }
        }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja2_Dziedziczenie.classes
{
    internal class Student(string name, string surname, DateTime dateOfBirth, Address address, int studentNumber)
        : Person(name, surname, dateOfBirth, address)
    {
        public int StudentNumber = studentNumber;
    }
}

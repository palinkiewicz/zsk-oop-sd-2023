using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja2_Dziedziczenie.classes
{
    internal class Teacher(string name, string surname, DateTime dateOfBirth, Address address, List<string> subjects)
        : Person(name, surname, dateOfBirth, address)
    {
        public List<string> Subjects = subjects;
    }
}

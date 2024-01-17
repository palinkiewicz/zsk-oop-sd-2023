/*
Dziedziczenie – zadanie 1
- Napisz program w języku C#, który ilustruje pojęcia programowania obiektowego,
takie jak klasy, dziedziczenie, właściwości i metody.
- Zdefiniuj klasę bazową Person, która ma pola name, surname i dateOfBirth oraz
konstruktor przyjmujący te wartości jako parametry.
- Dodaj do klasy Person metodę GetFullName, która zwraca pełne imię i nazwisko
osoby, oraz właściwość Age, która oblicza wiek osoby na podstawie daty urodzenia.
- Zdefiniuj klasę Address, która ma pola city, street, houseNumber i postalCode jako
właściwości oraz konstruktor przyjmujący te wartości jako parametry.
- Dodaj do klasy Person pole address typu Address i zmodyfikuj konstruktor klasy
Person, aby przyjmował obiekt klasy Address jako parametr.
- Zdefiniuj klasę pochodną Student, która dziedziczy po klasie Person i ma dodatkowe
pole studentNumber oraz konstruktor przyjmujący te wartości jako parametry.
- Zdefiniuj klasę pochodną Teacher, która dziedziczy po klasie Person i ma dodatkowe
pole subjects typu List<string> oraz konstruktor przyjmujący te wartości jako
parametry.
- Utwórz obiekty każdej klasy, używając słowa kluczowego new i podając odpowiednie
wartości w konstruktorach.
- Wyświetl dane utworzonych obiektów, używając metody Console.WriteLine i
właściwości obiektów.
 */

using System.Reflection.PortableExecutable;
using System;
using lekcja2_Dziedziczenie.classes;

namespace lekcja2_Dziedziczenie
{
    internal class Program
    {
        static void WriteAddressInfo(Address address, string header = "Address")
        {
            Console.WriteLine(header + ":");
            Console.WriteLine("\tCity = " + address.City);
            Console.WriteLine("\tStreet = " + address.Street);
            Console.WriteLine("\tHouseNumber = " + address.HouseNumber);
            Console.WriteLine("\tPostalCode = " + address.PostalCode);
        }
        static void WritePersonInfo(Person person, string header = "Person")
        {
            Console.WriteLine(header + ":");
            Console.WriteLine("\tName = " + person.Name);
            Console.WriteLine("\tSurname = " + person.Surname);
            Console.WriteLine("\tDate = " + person.DateOfBirth);
            Console.WriteLine("\tAge = " + person.Age);
        }

        static void Main(string[] args)
        {
            // Address class
            Address someAddress = new("Poznań", "Bukowska", 53, "60-567");
            WriteAddressInfo(someAddress);
            Console.WriteLine();

            // Person class
            Person somePerson = new("John", "Smith", new DateTime(1960, 3, 8), new Address("New York", "Builders Street", 12, "10012"));
            WritePersonInfo(somePerson);
            WriteAddressInfo(somePerson.Address, "Person's address");
            Console.WriteLine();

            // Student class
            Student someStudent = new("Jack", "Porkchop", new DateTime(2006, 1, 2), new Address("Berlin", "Kurfürstendamm", 3, "10119"), 20);
            WritePersonInfo(someStudent, "Student");
            Console.WriteLine("\tStudentNumber = " + someStudent.StudentNumber);
            WriteAddressInfo(someStudent.Address, "Student's address");
            Console.WriteLine();

            // Teacher class
            Teacher someTeacher = new("Garry", "White", new DateTime(1945, 11, 26), new Address("London", "Carnaby Street", 3, "EC1R"), ["Maths", "Physics"]);
            WritePersonInfo(someTeacher, "Teacher");
            Console.WriteLine("\tSubjects:");
            someTeacher.Subjects.ForEach(subject => Console.WriteLine("\t\t -" + subject));
            WriteAddressInfo(someTeacher.Address, "Teacher's address");
        }
    }
}

﻿/*
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

namespace lekcja2_Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

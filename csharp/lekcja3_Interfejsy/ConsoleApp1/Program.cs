/*
Interfejsy

- Zdefiniuj klasę Book, która ma reprezentować informacje o książce, takie jak tytuł,
autor, rok wydania i cena.

- Zaimplementuj interfejs IComparable<Book> w klasie Book, który pozwala na
porównywanie obiektów typu Book według ich ceny. Aby to zrobić, zdefiniuj metodę
CompareTo(Book other), która zwraca liczbę całkowitą oznaczającą relację pomiędzy
bieżącym obiektem a innym obiektem typu Book.

- Zdefiniuj konstruktor klasy Book, który przyjmuje jako parametry tytuł, autora, rok
wydania i cenę książki i inicjalizuje odpowiednie pola klasy.

- Zdefiniuj metodę ToString() klasy Book, która zwraca reprezentację tekstową obiektu
typu Book, składającą się z tytułu, autora, roku wydania i ceny książki, oddzielonych
przecinkami.

- Zdefiniuj klasę Program, która zawiera metodę Main, w której utwórz listę książek
typu Book i dodaj do niej kilka przykładowych obiektów.

- Posortuj listę książek według ceny, używając metody Sort klasy List<T>. Wyświetl
posortowaną listę na konsoli, używając metody ToString() klasy Book.

- Posortuj listę książek według innych kryteriów, np. daty publikacji, autora, tytułu,
używając metod OrderBy, OrderByDescending i ThenBy z przestrzeni nazw
System.Linq. Wyświetl posortowane listy na konsoli, używając metody ToString() klasy
Book.
*/
using ConsoleApp1.classes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books =
            [
                new("Pan Tadeusz", "Adam Mickiewicz", 1834, 19.99f),
                new("Lalka", "Bolesław Prus", 1889, 29.99f),
                new("Katarynka", "Bolesław Prus", 1880, 23.99f),
                new("The Little Prince", "Antoine de Saint-Exupéry", 1943, 14.99f)
            ];

            books.ForEach(book => { Console.WriteLine(book); });

            books.Sort();
            Console.WriteLine();
            Console.WriteLine("Posortowane wg ceny");
            books.ForEach(Console.WriteLine);

            books = [.. books.OrderBy(book => book.Year).ThenBy(book => book.Author)];
            Console.WriteLine();
            Console.WriteLine("Posortowane wg roku a potem autora");
            books.ForEach(Console.WriteLine);

            books = [.. books.OrderByDescending(book => book.Title)];
            Console.WriteLine();
            Console.WriteLine("Posortowane wg tytułu od Z do A");
            books.ForEach(Console.WriteLine);
        }
    }
}

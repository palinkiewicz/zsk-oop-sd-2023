/*
Zadania - delegaty

● Napisz program w języku C#, który używa delegatów do wykonania
operacji arytmetycznych na dwóch liczbach podanych przez
użytkownika.

● Zadeklaruj typ delegata, który przyjmuje i zwraca int, i nazwij go
Operation.

● Zdefiniuj cztery metody statyczne, które realizują operacje dodawania,
odejmowania, mnożenia i dzielenia dwóch liczb, i nazwij je odpowiednio
Add, Subtract, Multiply i Divide.

● Zdefiniuj metodę statyczną, która wyświetla wynik operacji na liczbach, i
nazwij ją DisplayResult. Metoda ta powinna przyjmować jako argumenty
instancję delegata Operation, dwie liczby i wywoływać metodę związaną
z delegatem na tych liczbach. Metoda ta powinna również obsługiwać
wyjątek DivideByZeroException, jeśli wystąpi, i wyświetlać odpowiedni
komunikat o błędzie.

● Zdefiniuj funkcję, która pobiera liczbę całkowitą nieujemną od
użytkownika, i nazwij ją GetIntFromUser. Funkcja ta powinna wyświetlać
podpowiedź dla użytkownika, pobierać dane od użytkownika,
sprawdzać, czy dane są poprawne i nieujemne, i zwracać liczbę. Jeśli
dane są nieprawidłowe, funkcja powinna wyświetlać komunikat o
błędzie i prosić użytkownika o ponowne wprowadzenie danych.

● W metodzie Main, pobierz dwie liczby od użytkownika za pomocą
funkcji GetIntFromUser i zapisz je w zmiennych a i b.

● Utwórz cztery instancje delegata Operation i przypisz im metody Add,
Subtract, Multiply i Divide.

● Wywołaj metodę DisplayResult dla każdej instancji delegata i przekaż jej
zmienne a i b jako argumenty.

● Przetestuj swój program dla różnych danych wejściowych i sprawdź, czy
działa poprawnie.
*/
namespace lekcja4_Delegaty
{
    internal class Program
    {
        public delegate int Operation(int x, int y);

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y) 
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static void DisplayResult(Operation operation, int x, int y)
        {
            if (operation.Method.Name == "Divide" && y == 0)
            {
                Console.WriteLine("Błąd. Dzielenie przez 0!");
                return;
            }

            Console.WriteLine($"Wynik operacji {operation.Method.Name} na liczbach {x} i {y} wynosi {operation(x, y)}");
        }

        public static int GetIntFromUser(string prompt)
        {
            int result = 0;
            bool valid = true;

            do
            {
                if (!valid)
                {
                    Console.WriteLine("Błąd. Należy podać liczbę całkowitą");
                }
                else if (result < 0)
                {
                    Console.WriteLine("Błąd. Liczba nie może być mniejsza od 0");
                }

                Console.Write($"{prompt}: ");
                valid = int.TryParse(Console.ReadLine(), out result);
            }
            while ( !valid || result < 0 );

            return result;
        }

        static void Main(string[] args)
        {
            int a = GetIntFromUser("Podaj liczbę a");
            int b = GetIntFromUser("Podaj liczbę b");

            Operation addition = new Operation(Add);
            Operation subtraction = new Operation(Subtract);
            Operation multiplication = new Operation(Multiply);
            Operation division = new Operation(Divide);

            DisplayResult(addition, a, b);
            DisplayResult(subtraction, a, b);
            DisplayResult(multiplication, a, b);
            DisplayResult(division, a, b);
        }
    }
}

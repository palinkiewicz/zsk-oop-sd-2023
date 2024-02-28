namespace _4_2_Delegaty
{
    delegate bool Logic(bool a, bool b);

    internal class Program
    {
        static bool And(bool a, bool b)
        {
            return a && b;
        }

        static bool Or(bool a, bool b)
        {
            return a || b;
        }

        static bool Xor(bool a, bool b)
        {
            return a ^ b;
        }

        static bool Not(bool a, bool b)
        {
            return !a;
        }

        static void DisplayResult(Logic logic, bool a, bool b)
        {
            try
            {
                bool result = logic(a, b);
                Console.WriteLine($"Rezultat {logic.Method.Name} {a} {b} wynosi {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static bool GetBoolFromUser() {
            while (true)
            {
                Console.Write("Wprowadź true lub false: ");
                bool value;

                if (bool.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowe dane.");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

namespace lekcja1_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i wieków osób.
                1) Użyj tablicy, aby przechować wczytane imiona i wiek osób.
                2) Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A.
                3) Użyj słownika, aby przechować pary (imie, wiek) dla wszystkich osób, których wiek jest większy niż 18 lat.
                4) Wypisz na ekranie zawartość tablicy, listy i słownika.
            */

            // 1)
            int n = ReadInt("Podaj liczbę osób", 0, int.MaxValue);

            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                string name = ReadString($"Podaj imię osoby {i + 1}.");

                names[i] = name[..1].ToUpper() + name[1..].ToLower();
                ages[i] = ReadInt($"Podaj wiek osoby {i + 1}.", 0, 150);
            }

            // 2)
            List<string> namesStartingOnA = names.Where(name => name.StartsWith('A')).ToList();

            // 3)
            Dictionary<string, int> adults = [];

            for (int i = 0; i < n; i++)
            {
                if (ages[i] >= 18)
                {
                    adults.Add(names[i], ages[i]);
                }
            }

            // 4)
            Console.WriteLine("Zawartość tablic:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" - {0}, lat {1}", names[i], ages[i]);
            }

            Console.WriteLine("Lista imion, które zaczynają się na A:");
            namesStartingOnA.ForEach(name => Console.WriteLine(" - {0}", name));

            Console.WriteLine("Słownik imion i nazwisk osób pełnoletnich:");
            foreach (KeyValuePair<string, int> item in adults)
            {
                Console.WriteLine(" - {0}, lat {1}", item.Key, item.Value);
            }
        }

        static string ReadString(string prompt)
        {
            string input;

            do
            {
                Console.Write("{0}: ", prompt);
                input = Console.ReadLine() ?? "";

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Podaj prawidłowy ciąg znaków.");
                }
            } while (string.IsNullOrEmpty(input));

            return input;
        }

        static int ReadInt(string prompt, int lowest, int highest)
        {
            int input;
            bool valid;

            do
            {
                Console.Write("{0}: ", prompt);
                valid = int.TryParse(Console.ReadLine(), out input);

                if (!valid)
                {
                    Console.WriteLine("Podaj prawidłową liczbę całkowitą.");
                }
                else if (input < lowest || input > highest)
                {
                    valid = false;
                    Console.WriteLine("Liczba musi być w zakresie od {0} do {1}", lowest, highest);
                }
            } while (!valid);

            return input;
        }
    }
}

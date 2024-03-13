/*
o Zdefiniuj delegat MessageHandler, który przyjmuje string i zwraca void.
o Zdefiniuj klasę Publisher z polem MessageEvent typu MessageHandler,
zadeklarowanym jako event.
o Zdefiniuj metodę SendMessage w klasie Publisher, która przyjmuje string i zwraca
void. Metoda ta ma wywoływać zdarzenie MessageEvent, jeśli ma subskrybentów.
*/

/*
o Zdefiniuj klasę Subscriber z metodą OnMessageReceived, która przyjmuje string i
zwraca void. Metoda ta ma wypisywać na konsolę wiadomość otrzymaną od
wydawcy.
o Zdefiniuj klasę Program z metodą Main, która jest punktem wejścia programu.
o W metodzie Main utwórz obiekty klasy Publisher i klasy Subscriber.
o Zasubskrybuj zdarzenie MessageEvent za pomocą metody OnMessageReceived.
o Wywołaj metodę SendMessage kilka razy z różnymi parametrami i sprawdź, czy
subskrybent otrzymuje wiadomości.
o Anuluj subskrypcję zdarzenia i wywołaj metodę SendMessage ponownie. Sprawdź,
czy subskrybent nadal otrzymuje wiadomości
*/

/*
samodzielne wykonanie
o Zdefiniuj klasę Program z metodą Main, która jest punktem wejścia programu.
o W metodzie Main utwórz obiekty klasy Publisher i dwóch obiektów klasy Subscriber.
Nadaj im odpowiednie wartości pól Threshold i Name.
o Zasubskrybuj zdarzenie MessageEvent za pomocą metody OnMessageReceived dla
obu subskrybentów.
o Wywołaj metodę SendMessage kilka razy z różnymi parametrami i sprawdź, czy
subskrybenci otrzymują tylko te wiadomości, które spełniają ich próg priorytetu.2137
*/
namespace lekcja5_1_1_Zdarzenia
{
    public delegate void MessageHandler(string message, int priority);

    public class Publisher
    {
        public event MessageHandler MessageEvent;

        public void SendMessage(string message, int priority)
        {
            MessageEvent?.Invoke(message, priority);
        }
    }

    public class Subscriber
    {
        public int Threshold;
        public string Name;

        public Subscriber(int threshold, string name)
        {
            Threshold = threshold;
            Name = name;
        }

        public void OnMessageReceived(string message, int priority)
        {
            if (priority <= Threshold)
            {
                Console.WriteLine("{0} otrzymał wiadomość \"{1}\" o priorytecie {2}", Name, message, priority);
            }
            else
            {
                Console.WriteLine("{0} nie otrzymał wiadomości o priorytecie {1}", Name, priority);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new();
            Subscriber sub1 = new(2, "Subscriber 1");
            Subscriber sub2 = new(5, "Subscriber 2");

            pub.MessageEvent += sub1.OnMessageReceived;

            pub.SendMessage("Hello sub1", 1);

            pub.MessageEvent += sub2.OnMessageReceived;

            pub.SendMessage("Hello everyone", 1);
            pub.SendMessage("Second message", 3);
            pub.SendMessage("This won't display", 6);
            pub.SendMessage("Hello again", 2);
        }
    }
}

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
namespace lekcja5_1_Zdarzenia
{
    public delegate void MessageHandler(string message);

    public class Publisher
    {
        public event MessageHandler MessageEvent;

        public void SendMessage(string message)
        {
            MessageEvent?.Invoke(message);
        }
    }

    public class Subscriber
    {
        public void OnMessageReceived(string message)
        {
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new();
            Subscriber sub = new();

            pub.MessageEvent += sub.OnMessageReceived;

            pub.SendMessage("Hello");
            pub.SendMessage("Second message");

            pub.MessageEvent -= sub.OnMessageReceived;
            pub.SendMessage("This won't display");

            pub.MessageEvent += sub.OnMessageReceived;
            pub.SendMessage("Hello again");
        }
    }
}

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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

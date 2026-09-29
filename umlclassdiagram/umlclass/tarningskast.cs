
    namespace umlclass
    {
        internal class tarningskast
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();

                // Grunduppgift: ett slumptal mellan 1 och 6
                int number = rnd.Next(1, 7);
                Console.WriteLine("Du kastade: " + number);

                // Extra: två tärningar + summa
                int tarning1 = rnd.Next(1, 7);
                int tarning2 = rnd.Next(1, 7);
                int summa = tarning1 + tarning2;

                Console.WriteLine("Tärning 1: " + tarning1);
                Console.WriteLine("Tärning 2: " + tarning2);
                Console.WriteLine("Summan av de två tärningarna är: " + summa);
            }
        }
    }
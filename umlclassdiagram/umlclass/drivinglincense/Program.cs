//namespace drivinglincense
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Ange ett tal");

//            // Läs inmatningen och konvertera den till ett heltal
//            int number = int.Parse(Console.ReadLine());

//            // Använd en for-loop för att iterera från 1 till 10
//            for (int i = 1; i <= 10; i++)
//            {
//                // Multiplicera inmatningstalet med det aktuella iterationsvärdet
//                int result = number * i;
//                // Skriv ut varje rad i multiplikationstabellen
//                Console.WriteLine(number + " x " + i + " = " + result);
//            }
//        }
//    }
//}


internal class Program
{
    private static void Main(string[] args)
    {
        //Generera ett slumptal mellan 1 och 100
        Random rnd = new Random();
        int secretNumber = rnd.Next(1, 101);

        //Be användaren att gissa numret.
        Console.WriteLine("Gissa talet från 1 till 100");
        int gissning = 0;
        int antalGissningar = 0; // move declaration here so it's in scope for the whole loop

        //Använd en while-loop för att fortsätta be om gissningar tills användaren gissar rätt nummer.
        while (gissning != secretNumber)
        {
            gissning = int.Parse(Console.ReadLine());
            antalGissningar++; // increment on each attempt

            if (gissning == secretNumber)
            {
                Console.WriteLine("Grattis! Du gissade siffran!");
                Console.WriteLine("Grattis! Du behövde " + antalGissningar + " försök.");
            }
            else if (gissning < secretNumber)
            {
                Console.WriteLine("För lågt!");
            }
            else
            {
                Console.WriteLine("För högt!");
            }
        }
    }
}
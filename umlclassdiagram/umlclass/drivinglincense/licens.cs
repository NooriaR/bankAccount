using System;
using System.Collections.Generic;
using System.Text;


//Skapa ett C#-program som frågar användaren om deras ålder och om de har ett gilltigt körkort.Programmet bör avgöra om användaren lagligt kan köra bil (t.ex. ålder >= 18 och har en giltig licens)

namespace drivinglincense
{
    public class licens
    {
        static void Kor (string[] args)
        {
            //Skapa ett C#-program som frågar användaren om
            //deras ålder och om de har ett giltigt körkort.
            //Programmet bör avgöra om användaren lagligt kan
            //köra bil(t.ex.ålder >= 18 och har en giltig licens).
            Console.WriteLine("Ange din ålder:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Har du ett giltigt körkort? (ja/nej)");
                string hasLicenseInput = Console.ReadLine();
                if (hasLicenseInput.ToLower() == "ja")
                {
                    Console.WriteLine("Du kan lagligt köra bil.");
                }
                else
                {
                    Console.WriteLine("Du kan inte lagligt köra bil.");
                }
            }
            else
            {
                Console.WriteLine("Du är inte tillräckligt gammal för att köra bil.");
            }
        }
    }
}

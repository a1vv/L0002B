using System;

namespace Inlämning_1_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ChangeCalculator();
                Console.WriteLine("\nPress any key to start a new calculation.");
                Console.ReadKey();
                Console.WriteLine();
            }
        }

        private static void ChangeCalculator()
        {
            string pris, betalt;
            Console.Write("Ange pris: ");
            pris = Console.ReadLine();
            Console.Write("\nBetalt: ");
            betalt = Console.ReadLine();

            (Boolean, int) parsedPrice = ParsedCurrency(pris);
            (Boolean, int) parsedAmount = ParsedCurrency(betalt);

            // Alert user if input is invalid
            if (!parsedAmount.Item1 || !parsedPrice.Item1)
            {
                Console.WriteLine("\nInvalid input. Input must be a positive integer.");
                return;
            }
            else if (parsedAmount.Item2 < parsedPrice.Item2)
            {
                Console.WriteLine($"\nIngen växel möjlig! Det saknas {parsedPrice.Item2 - parsedAmount.Item2}kr.");
                return;
            }
            // denominations
            Int32[] denoms = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            // create array to hold values of change
            Int32[] change = new Int32[denoms.Length];
            Console.WriteLine("\nVäxel tillbaka:");
            int remainingAmount = parsedAmount.Item2 - parsedPrice.Item2;

            // loop through all denominators, descending order, and calculate the count of each. 
            for (int i = denoms.Length - 1; i >= 0; i--)
            {
                change[i] = (remainingAmount) / denoms[i];
                remainingAmount = remainingAmount - change[i] * denoms[i];

                // Write to console if the denominator is used at least once
                if (change[i] > 0)
                {
                    Console.WriteLine($"{denoms[i]}: {change[i]}st");
                }
                
            }
        }

        private static (Boolean,int) ParsedCurrency(string input)
        {
            int amount;
            // try to parse the input. Set to negative number if not parseable.
            try
            {
                amount = int.Parse(input);
            }
            catch
            {
                amount = -1;
            }
            // if the amount is negative, the input was invalid
            if (amount < 0)
            {
                return (false, amount);
            }
            return (true, amount);
        }
    }
}

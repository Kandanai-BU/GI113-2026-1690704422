/*
 * Student ID : 1690704422
 * Name       : Kandanai Churatch
 * Section    : 129D
 * No.        : 21
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    class Assignment02
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Gold";
            const double SmeltRate = 0.5;
            const double SalvageRate = 0.8;
            const double MaxBatch = 300;

            Console.WriteLine("\n\n\n===================== THE FORGE =====================\n");
            Console.WriteLine($"Would you like to smelt {MaterialName} or breakdown {MaterialName}?");
            Console.WriteLine($"S = Smelt     (turn your {MaterialName} ores into {MaterialName} ingots)");
            Console.WriteLine($"B = Breakdown (turn your {MaterialName} ingots into {MaterialName} ores)");
            Console.Write("\nType in 'S' or 'B': ");
            char.TryParse(Console.ReadLine(), out char menuChoice);
            Console.WriteLine();

            if (menuChoice == 'S' || menuChoice == 's')
            {
                Console.WriteLine($"Smelt Rate: 1 Ore = {1 * SmeltRate} Ingot\nHow much ores would you like to smelt?");
                Console.Write("\nEnter Amount (0.01 - 300): ");
                double.TryParse(Console.ReadLine(), out double enteredAmount);
                Console.WriteLine();
                
                if (enteredAmount > 0 && enteredAmount <= MaxBatch)
                {
                    Console.WriteLine($"=> {enteredAmount:F2} {MaterialName} Ore = {enteredAmount * SmeltRate :F2} {MaterialName} Ingot");
                }
                else
                {
                    Console.WriteLine("Invalid Amount, please only input a number within 0.01 and 300");
                }

            }
            else if (menuChoice == 'B' || menuChoice == 'b')
            {
                Console.WriteLine($"Breakdown Rate: 1 Ingot = {1 / SalvageRate} Ore\nHow much ingots would you like to breakdown?");
                Console.Write("\nEnter Amount (0.01 - 300): ");
                double.TryParse(Console.ReadLine(), out double enteredAmount);
                Console.WriteLine();
                
                if (enteredAmount > 0 && enteredAmount <= MaxBatch)
                {
                    Console.WriteLine($"=> {enteredAmount:F2} {MaterialName} Ingot = {enteredAmount / SalvageRate :F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Invalid Amount, please only input a number within 0.01 and 300");
                }
            }
            else
            {
                Console.WriteLine("Invalid Answer, please only type 'S' or 'B'");
            }

            Console.WriteLine("\n\n\n");
        }
    }
}

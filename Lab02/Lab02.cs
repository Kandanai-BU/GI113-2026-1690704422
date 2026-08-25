/*
 * Student ID : 1690704422
 * Name       :
 * Section    : 129F
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Lab02Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            //Lab02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercentage}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP {currentHp} / {maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercentage}%");

            //Lab02 Part B

        }
    }
}

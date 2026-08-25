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
            PartAPartB(args);
        }
        static void PartAPartB(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            //Lab02 Part A result
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

            //part B
            string characterName = "Villager";
            int hp = 10;
            float movementSpeed = 10f;
            double jumpForce = 0.5;
            bool isHostile = false;

            Console.WriteLine("===== PART B: MY CHARACTER STATS =====");
            Console.WriteLine();
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Movement Speed: {movementSpeed}");
            Console.WriteLine($"Jump Force: {jumpForce}");
            if (isHostile){Console.WriteLine("Hostile");}
            else{Console.WriteLine("Friendly");}
            Console.WriteLine();

            characterName = "Dog";
            hp = 20;
            movementSpeed = 25f;
            jumpForce = 1.5;
            isHostile = false;

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Movement Speed: {movementSpeed}");
            Console.WriteLine($"Jump Force: {jumpForce}");
            if (isHostile){Console.WriteLine("Hostile");}
            else{Console.WriteLine("Friendly");}
            Console.WriteLine();

            characterName = "Zombie";
            hp = 30;
            movementSpeed = 8f;
            jumpForce = 0.3;
            isHostile = true;

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Movement Speed: {movementSpeed}");
            Console.WriteLine($"Jump Force: {jumpForce}");
            if (isHostile){Console.WriteLine("Hostile");}
            else{Console.WriteLine("Friendly");}
            Console.WriteLine();

            characterName = "Dragon";
            hp = 120;
            movementSpeed = 45f;
            char activationKey = 'K';
            isHostile = true;

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Movement Speed: {movementSpeed}");
            Console.WriteLine($"Activation Key: {activationKey}");
            if (isHostile){Console.WriteLine("Hostile");}
            else{Console.WriteLine("Friendly");}
            Console.WriteLine();
        }
    }
}

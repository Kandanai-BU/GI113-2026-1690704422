/*
 * Student ID : 1690704422
 * Name       : Kandanai Churatch
 * Section    : 129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
 namespace Assignment01
{
    internal class Assignment01
    {
        static void Main(string[] args)
        {
            const string Title = "Character Stats : GTA V";

            var characterName = "Trevor Philips";
            var characterInitial = 'T';
            int characterAge = 49;
            float characterHeight = 1.86f;
            double bankBalance = -309411.65;
            string bankBalanceMoneySign = bankBalance.ToString("$#,0.00");
            bool isAPlayableCharacter = true;

            Console.WriteLine($"\n\n======== {Title} ========\n");
            Console.WriteLine($"Character Name     : {characterName}");
            Console.WriteLine($"Initial            : {characterInitial}");
            Console.WriteLine($"Age                : {characterAge} years old");
            Console.WriteLine($"Height             : {characterHeight} m");
            Console.WriteLine($"Bank Balance       : {bankBalanceMoneySign}");
            Console.WriteLine($"Playable Character : {isAPlayableCharacter}");

            Console.WriteLine($"\n\n-------- Type Conversion --------\n");
            double characterLevelAsDouble = characterAge;
            Console.WriteLine($"Age as a double (implicit cast): {characterLevelAsDouble}");
            int bankBalanceTruncated = (int)bankBalance; //explicit cast
            Console.WriteLine($"Bank Balance cast (truncated)  : {bankBalanceTruncated}");
            int bankBalanceRounded = Convert.ToInt32(bankBalance); //Convert
            Console.WriteLine($"Bank Balance Convert (rounded) : {bankBalanceRounded}\n\n");
        }
    }
}
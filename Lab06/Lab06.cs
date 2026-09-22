/*
 * Student ID : 1690704422
 * Name       : Kandanai Churatch
 * Section    : 129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab06
{
    class Lab06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("In a post-apocalyptic world, you went into the woods for a hunt.");
            Console.WriteLine("You were looking for deers, but you came across something else.");
            Console.WriteLine("Three wolf pups, all hiding under the same root of a big tree.");
            Console.WriteLine("There was blood trail, starting from right beside the tree\nand leads into the dense forest.");
            Console.WriteLine("So you made a decision...");
            Console.WriteLine("\n================= MAKE YOUR DECISION =============================");
            Console.WriteLine("1. You ignore the pups and the blood trail, and go on with your hunt.");
            Console.WriteLine("2. You pick up the pups and bring them back to your home.");
            Console.WriteLine("3. You follow the blood trail and walk into the dense forest.");

            Console.Write("\nType in your choice (1, 2, or 3): ");
            int.TryParse(Console.ReadLine(), out int choiceNumber);
            Console.WriteLine();

            if (choiceNumber == 1)
            {
                Console.WriteLine(">>You ignore the pups and the blood trail, and go on with your hunt.");
                Console.WriteLine("You walk for two more kilometers, and you spot a deer.");
                Console.WriteLine("So you shoot the deer, hitting it right in the chest, and it dies.");
                Console.WriteLine("You carry the deer on your back and head back home.");
                Console.WriteLine("The hunt was successful.");
            }
            else if (choiceNumber == 2)
            {
                Console.WriteLine(">>You pick up the pups and bring them back to your home.");
                Console.WriteLine("You notice that the pups were very tired and fell asleep in your arms.");
                Console.WriteLine("You walk for 40 minutes, and finally arrive at your home.");
                Console.WriteLine("The pups are awake and are probably very hungry.");
                Console.WriteLine("So you cook up some chicken stew from the fridge and feed them.");
                Console.WriteLine("You will raise them and they will become your best friends.");
            }
            else if (choiceNumber == 3)
            {
                Console.WriteLine(">>You follow the blood trail and walk into the dense forest.");
                Console.WriteLine("The smells, and the silence of the surroundings, it's very weird.");
                Console.WriteLine("You feels very uneasy, so you are clutching your gun.");
                Console.WriteLine("The blood trail ends here, you see a corpse of a wolf.");
                Console.WriteLine("Probably who's the pups belong to, so unfortunate.");
                Console.WriteLine("Then suddenly, a giant 8 feet tall bear jumps toward you!");
                Console.WriteLine("The bear pushes you and you fall on your back, now it's on top of you.");
                Console.WriteLine("It begins to viciously maul you with its sharp claws and teeth.");
                Console.WriteLine("While your arms and chest are being ripped open, you notice...");
                Console.WriteLine("This isn't a normal bear, its eyes are swollen and red,");
                Console.WriteLine("it's drooling litres, and it barely got any hair left on its body.");
                Console.WriteLine("All the signs of the zombie infection, the one that wiped out civilization.");
                Console.WriteLine("You never knew that other animals could become a zombie too.");
                Console.WriteLine("The bear continues to rip you apart one by one.");
                Console.WriteLine("You die.");
            }
            else
            {
                Console.WriteLine("Invalid answer, please press run again and only type 1, 2, or 3.");
            }

            Console.WriteLine("\n\n\n");
        }
    }
}

// Dice Roll Simulator by Leo
#nullable disable
Console.Clear();

// Variables
Random rnd = new Random();

// Main Loop
bool loop = true;

while (loop) 
{

    // Menu
    Console.WriteLine("\nDice Roll Simulator Menu");

    // Options
    Console.WriteLine("1. Roll Dice Once");
    Console.WriteLine("2. Roll Dice 5 Times");
    Console.WriteLine("3. Roll Dice 'n' Times");
    Console.WriteLine("4. Roll Dice until Snake Eyes");
    Console.WriteLine("5. Exit");

    // Option Select
    Console.Write("Select an option (1-5):");
    string chooseNumber = Console.ReadLine();

    // Option 1
    if (chooseNumber == "1") {
        Console.WriteLine("\nRoll Dice Once");
        int dice1 = (rnd.Next(1,6));
        int dice2 = (rnd.Next(1,6));
        Console.WriteLine($"{dice1},{dice2} (sum: {dice1 + dice2})");
    }
    // Option 2
    if (chooseNumber == "2") {
        Console.WriteLine("\nRoll Dice 5 Times");
        for (int n = 1; n <= 5; n++) {
            int dice1 = (rnd.Next(1,6));
            int dice2 = (rnd.Next(1,6));
            Console.WriteLine($"{dice1},{dice2} (sum: {dice1 + dice2})");
        }
    }
    // Option 3
    if (chooseNumber == "3") {
        Console.WriteLine("\n Roll Dice 'n' Times");
        Console.Write("How many times would you like to roll:");
        int rollAmount = Convert.ToInt32(Console.ReadLine());
        for (int n = 1; n <= rollAmount; n++) {
            int dice1 = (rnd.Next(1,6));
            int dice2 = (rnd.Next(1,6));
            Console.WriteLine($"{dice1},{dice2} (sum: {dice1 + dice2})");
        }
    }

    // Option 4
    if (chooseNumber == "4") {
        Console.WriteLine("\nRoll Dice Until Snake Eyes");
        int rollCount = 0;
        int dice1 = 0;
        int dice2 = 0;
        while (dice1 != 1 || dice2 != 1) {
            dice1 = (rnd.Next(1,6));
            dice2 = (rnd.Next(1,6));
            Console.WriteLine($"{dice1},{dice2} (sum: {dice1 + dice2})");
            rollCount++;
        }
        Console.WriteLine($"SNAKE EYES! It took {rollCount} rolls to get snake eyes");
    }

    // End Loop
    if(chooseNumber == "5") {
        loop = false;
    }

}
Console.WriteLine("\nGoodbye");
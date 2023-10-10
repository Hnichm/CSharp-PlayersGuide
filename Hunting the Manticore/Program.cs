
int cityHealth = 15;
int manticoreHealth = 10;
int currentRound = 1;
int manticoreLocation = NumberInRange();

while (true)
{

    Display(manticoreLocation, currentRound, cityHealth, manticoreHealth, CannonDamage(currentRound));
    currentRound += 1;
    cityHealth -= 1;


    if (manticoreHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nThe Manticore has been destroyed! The city of Consolas has been saved!");
        Console.ForegroundColor = ConsoleColor.Gray;
        break;
    }
    else if (cityHealth <= 0 )
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nThe city has fallen and the Manticore reigns victorious...");
        Console.ForegroundColor = ConsoleColor.Gray;
        break;
    }
    

}

int NumberInRange()
{
    Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore? ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > -1 && num < 101)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Valid input, manticore has been stationed at position {num}");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Please wait, clearing console");
        for( int i = 0; i < 4; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);

        }
        for(int i = 0; i < 3; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(500);
            Console.Write(". ");
            
        }
        Console.Clear();
        Console.ForegroundColor= ConsoleColor.Gray;
        return num;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input, please choose a number from 0 to 100");
        Console.ForegroundColor = ConsoleColor.Gray;
        return NumberInRange();
    }
}

void Display(int manticoreLocation ,int round, int cityHealth, int manticoreHealth, int cannonDamage)
{
    for(int i = 0; i < 21; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();
    Console.Write($"STATUS: ");
    Console.Write($"Round: {round} ");
    Console.Write("City");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($" {cityHealth}/15");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(" Manticore:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($" {manticoreHealth}/ 10\n");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
    ManticoreDetection(manticoreLocation, cannonDamage);
    for(int i = 0; i < 21; i++)
    {
        Console.Write("-");
    }
}

int CannonDamage(int currentRound)
{
    if(currentRound % 3 == 0 && currentRound % 5 == 0)
    {
        return 10;
    }
    else if(currentRound % 3 == 0 || currentRound % 5 == 0)
    {
        return 3;
    }
    return 1;
}

int ManticoreDetection(int manticoreLocation, int damage)
{
    Console.Write("Enter desired cannon range: ");
    int cannonShot = Convert.ToInt32(Console.ReadLine());
    if(cannonShot < manticoreLocation)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
        return cannonShot;
    }
    else if(cannonShot > manticoreLocation)
    {
        Console.WriteLine("That round OVERSHOT the target.");
        return cannonShot;
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHealth -= CannonDamage(currentRound);
        return cannonShot;
    }
}
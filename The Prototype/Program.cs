Console.ForegroundColor = ConsoleColor.White;
Console.Write("User 1, enter a number between 0 and 100: ");

bool user1ValidNumber = false;
bool user2CorrectNumber = false;
while (true)
{
    int user1Number = 0;
    int user2Number = 0;

    while (user1ValidNumber == false)
    {
        user1Number = Convert.ToInt32(Console.ReadLine());
        if (user1Number > -1 && user1Number < 101)
        {
            user1ValidNumber = true;
            Console.WriteLine("Number valid, clearing console.");

        }
        else
        {
            Console.Write("Invalid number, please pick a number between 0 and 100: ");
        }
    }

    for (int i = 0; i < 5; i++)
    {
        Thread.Sleep(500);
        Console.Write(". ");
    }

    Console.Clear();

    while(user2CorrectNumber == false)
    {
        Console.Write("User 2, guess a number between 0 and 100: ");
        user2Number = Convert.ToInt32(Console.ReadLine());
        if(user2Number > user1Number)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Number too high, please try again.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if(user2Number < user1Number)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Number too low, please try again. ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You guessed correctly!");
            user2CorrectNumber = true;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    break;
}
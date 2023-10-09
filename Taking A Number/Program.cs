int AskForNumber(string text)
{
    Console.WriteLine(text);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");

int AskForNumberInRange(string text, int min, int max)
{
   
    while (true)
    {
        Console.WriteLine(text);
        int answer = Convert.ToInt32(Console.ReadLine());
        if (answer > min && answer < max)
        {
         
            return answer;
        }
        else
        {
            Console.WriteLine($"Please write a number between {min} and {max}");
        }
    }
    
}

AskForNumberInRange("Boop", 10, 20);
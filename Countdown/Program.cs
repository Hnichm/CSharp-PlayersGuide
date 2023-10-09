void Countdown(int num)
{
    if (num == 0) return;
    Console.WriteLine(num);
    Countdown(num - 1);
    
}

Countdown(10);
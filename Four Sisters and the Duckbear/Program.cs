Console.WriteLine("Please enter number of chocolate eggs gathered.");
int numChocolateEggsGathered = int.Parse(Console.ReadLine());
int numChocolateEggsPerSister = numChocolateEggsGathered / 4;
int numChocolateEggsForDuckbear = numChocolateEggsGathered % 4;
Console.WriteLine($"Number of eggs per sister: {numChocolateEggsPerSister}\nNumber of eggs for Duckbear {numChocolateEggsForDuckbear}");


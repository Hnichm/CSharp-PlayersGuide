Console.WriteLine("Please input 5 numbers to store into an array.");

// Asking user for numbers they wish to have in array
// There is no safety checks if user does not input an integer
Console.Write("Number 1: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 2:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 3: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 4: ");
int numberFour = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 5: ");
int numberFive = Convert.ToInt32(Console.ReadLine());

// Initalizing array with values user input.
int[] arrayOne = new int[] {numberOne, numberTwo, numberThree, numberFour, numberFive};


// Creating second array with a length of 5.
int[] arrayTwo = new int[5];

// Copying values from first array into second array
for(int index = 0; index < arrayOne.Length; index++)
{
    arrayTwo[index] = arrayOne[index];
}

// Writing values of equivalent index for array 1 and array 2 to show duplicator works correctly
for(int index = 0; index < arrayTwo.Length; index++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Array One index {index}: {arrayOne[index]}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Array Two index {index}: {arrayTwo[index]}");
}

Console.ForegroundColor = ConsoleColor.Gray;
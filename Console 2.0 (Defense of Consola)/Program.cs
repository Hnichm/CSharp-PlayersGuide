Console.Title = "The Defense of Consolas";

Console.Write("Target row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Target column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Deploy to:");
Console.WriteLine($"({targetRow}, {targetColumn - 1})");
Console.WriteLine($"({targetRow}, {targetColumn + 1})");
Console.WriteLine($"({targetRow - 1}, {targetColumn})");
Console.WriteLine($"({targetRow + 1}, {targetColumn})");

Console.ForegroundColor = ConsoleColor.White;

Console.Beep(100, 500);

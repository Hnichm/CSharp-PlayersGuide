Console.WriteLine("Please enter the base length of the triangle.");
int triangleBase = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the height of the triangle.");
int triangleHeight = Convert.ToInt32(Console.ReadLine());
int triangleArea = triangleBase * triangleHeight / 2;
Console.WriteLine($"Area of triangle: {triangleArea}");

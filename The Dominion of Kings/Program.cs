/*
 * Three kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest kingdom
among them. Each king rules an assortment of provinces, duchies, and estates. Collectively, they agree
to a point system that helps them judge whose kingdom is greatest: Every estate is worth 1 point, every
duchy is worth 3 points, and every province is worth 6 points. They just need a program that will allow
them to enter their current holdings and compute a point total.
Objectives:
• Create a program that allows users to enter how many provinces, duchies, and estates they have.
• Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
• Display the point total to the user
*/

Console.WriteLine("Please enter your name...");
string name = Console.ReadLine();
Console.WriteLine($"King {name}, input your total number of estates, followed by total number of duchy and finally total number of provinces.");
int kingEstates = Convert.ToInt32(Console.ReadLine());
int kingDuchys = Convert.ToInt32(Console.ReadLine());
int kingProvinces =  Convert.ToInt32(Console.ReadLine());
int totalScore = (kingEstates * 1) + (kingDuchys * 3) + (kingProvinces * 6);
Console.WriteLine($"King {name} the total point score of your kingdom is {totalScore}");
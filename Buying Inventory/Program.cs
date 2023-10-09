float ropeCost = 10;
float torchesCost = 15;
float climbingEquipmentCost = 25;
float cleanWaterCost = 1;
float macheteCost = 20;
float canoeCost = 200;
float foodSuppliesCost = 1;
string unknownOption = $"Apologies. I do not know what you are speaking of.";

Console.WriteLine("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies");
Console.Write("Which item do you wish to see the price of? (Input number) ");
int choice = Convert.ToInt32(Console.ReadLine());
Console.Write("And what is your name? ");
string name = Console.ReadLine();

switch (choice)
{
    case 1:
        if(name == "Nick")
        {
            ropeCost /= 2;
            Console.WriteLine($"Rope costs {ropeCost} gold.");
        }
        else
        {
            Console.WriteLine($"Rope costs {ropeCost} gold.");
        }
        break;
    case 2:
        if (name == "Nick")
        {
            torchesCost /= 2;
            Console.WriteLine($"Torches cost {torchesCost} gold.");
        }
        else
        {
            Console.WriteLine($"Torches cost {torchesCost} gold.");
        }
        break;
    case 3:
        if (name == "Nick")
        {
            climbingEquipmentCost /= 2;
            Console.WriteLine($"Climbing equipment costs {climbingEquipmentCost} gold.");
        }
        else
        {
            Console.WriteLine($"Climbing equipment costs {climbingEquipmentCost} gold.");
        }
        break;
    case 4:
        if (name == "Nick")
        {
            cleanWaterCost /= 2;
            Console.WriteLine($"Clean water costs {cleanWaterCost} gold.");
        }
        else
        {
            Console.WriteLine($"Clean water costs {cleanWaterCost} gold.");
        }
        break;
    case 5:
        if (name == "Nick")
        {
            macheteCost /= 2;
            Console.WriteLine($"Machete costs {macheteCost} gold.");
        }
        else
        {
            Console.WriteLine($"Machete costs {macheteCost} gold.");
        }
        break;
    case 6:
        if (name == "Nick")
        {
            canoeCost /= 2;
            Console.WriteLine($"Canoe costs {canoeCost} gold.");
        }
        else
        {
            Console.WriteLine($"Canoe costs {canoeCost} gold.");
        }
        break;
    case 7:
        if (name == "Nick")
        {
            foodSuppliesCost /= 2;
            Console.WriteLine($"Food supplies cost {foodSuppliesCost} gold.");
        }
        else
        {
            Console.WriteLine($"Food supplies cost {foodSuppliesCost} gold.");
        }
        break;
    default:
        Console.WriteLine(unknownOption);
        break;

}
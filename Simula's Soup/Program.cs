Recipe recipeChoice;
Ingredient ingredientChoice;
Seasoning seasoningChoice;


(Recipe, Ingredient, Seasoning) orderedItem = Order();
DisplayOrder(orderedItem.Item1, orderedItem.Item2, orderedItem.Item3);

Console.ReadKey();



(Recipe, Ingredient, Seasoning) Order()
{
    Console.WriteLine("Please select a type of food you would like: soup, stew or gumbo. ");
    recipeChoice = SelectRecipe();
    Console.WriteLine($"Please select a main ingredient for your {recipeChoice}: mushroom, chicken, carrot or potato.");
    ingredientChoice = SelectIngredient();
    Console.WriteLine($"And what seasoning would you like in your {ingredientChoice} {recipeChoice}: spicy, salty or sweet ?");
    seasoningChoice = SelectSeasoning();
    return (recipeChoice, ingredientChoice, seasoningChoice);
}

Recipe SelectRecipe()
{
    while (true)
    {
        string recipeSelection = Console.ReadLine().ToLower();

        switch(recipeSelection)
        {
            case "soup":
                return Recipe.soup;
            case "stew":
                return Recipe.stew;
            case "gumbo":
                return Recipe.gumbo;
            default:
                Console.WriteLine("Invalid choice, please choose soup, stew or gumbo.");
                break;
        }
    }
}

Ingredient SelectIngredient()
{
    while (true) { 
    string ingredientSelection = Console.ReadLine().ToLower();

        switch (ingredientSelection)
        {
            case "mushroom":
                return Ingredient.mushroom;
            case "chicken":
                return Ingredient.chicken;
            case "carrot":
                return Ingredient.carrot;
            case "potato":
                return Ingredient.potato;
            default:
                Console.WriteLine("Invalid choice, please choose mushroom, chicken, carrot or potato.");
                break;
        }
    }
}

Seasoning SelectSeasoning()
{
    while (true)
    {
        string seasoningSelection = Console.ReadLine().ToLower();
        switch (seasoningSelection)
        {
            case "spicy":
                return Seasoning.spicy;
            case "salty":
                return Seasoning.salty;
            case "sweet":
                return Seasoning.sweet;
            default:
                Console.WriteLine("Invalid selection, please choose spicy, salty or sweet.");
                break;
        }
    }
}

void DisplayOrder(Recipe recipe, Ingredient ingredient, Seasoning seasoning)
{
        Console.WriteLine($"Here is your {seasoning} {ingredient} {recipe}! That is what you asked for!");
}



enum Recipe { soup, stew, gumbo};
enum Ingredient { mushroom, chicken, carrot, potato};
enum Seasoning { spicy, salty, sweet};



while (true)
{
    Console.WriteLine("Pick a number from 1 to 5 to see what you can eat today");
    var userInput = Console.ReadLine();
    bool isParsed = int.TryParse(userInput, out int digitUserInput);

    if (digitUserInput != 0 && digitUserInput <= 5)
    {
        string meal = Meal(digitUserInput);

        Console.WriteLine("-----------------");
        Console.WriteLine($"Your meal for now is {meal}");
        Console.WriteLine("-----------------");
        continue;
    }


        continue; 
}

string Meal(int digitUserInput)
{
    string mealName = string.Empty;

    switch (digitUserInput)
    {
        case 1:
            mealName = "Chicken with carrot";
            break;
        case 2:
            mealName = "Wafell with strawberry";
            break;
        case 3:
            mealName = "Rise with fish";
            break;
        case 4:
            mealName = "Fish and chips";
            break;
        case 5:
            mealName = "Omelet";
            break;
        default:
            mealName = string.Empty;
            break;
    }

    return mealName;
}
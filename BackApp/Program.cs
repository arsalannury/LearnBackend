string starterTitle = "Press S if you want to start application and Press Q if you want go to settings";

string appMain = "Enter your suggestion letters to add to the archive";
string helperText = "Yo can enter 1 or 2 instead of enter letters";

string[] options = new string[2] { "1- Remove all letters", "2- Show all letters" };
List<string> letters = new List<string>();

do
{
    Console.WriteLine(starterTitle);

    string appType = Console.ReadLine() ?? "";
    bool isAppTypeChar = char.TryParse(appType, out char result);
    
    if (isAppTypeChar)
    {
        if (result.Equals('s'))
        {
            MainApplication();
        }
        else if (result.Equals('q'))
        {
            SettingApplication();
        }
    }

} while (true);


// helper methods to work with main app

void SettingApplication()
{
    Console.WriteLine(helperText);
    foreach (string item in options)
    {
        Console.WriteLine(item);
    }

    string settingOption = Console.ReadLine() ?? string.Empty;
    bool isSettingOptionValid = int.TryParse(settingOption, out int result);
    if (isSettingOptionValid)
    {
        if (result == 1)
        {
            letters.Clear();
            Console.WriteLine("All letters removed successfully");
        }
        else if (result == 2)
        {
            foreach (string item in letters)
            {
                Console.WriteLine(item);
            }
        }
    }
}

void MainApplication()
{
    StarterLogger();

    // get input from user
    string userSuggestion = Console.ReadLine() ?? string.Empty;
    string userSuggestionForCheck = userSuggestion.Replace(" ", string.Empty).ToLower();

    int duplicateLetterIndex = letters.FindIndex(lett => lett.Replace(" ", string.Empty) == userSuggestionForCheck);

    // should pass the fill string or the string under the 50 length
    if (userSuggestion == string.Empty || userSuggestion.Length > 50)
    {
        Console.Clear();
        //continue;
        return;
    }

    // letters and characters can not be duplicate
    if (duplicateLetterIndex != -1)
    {
        Console.WriteLine("You can not add duplicated letters, try another one");
        //continue;
        return;
    }

    // add to list with convert all word to lower -> A TEST TExt will be a test text
    letters.Add(userSuggestion.ToLower());
    Console.WriteLine("The item added successfully ✔✔✔🤞");
    //continue;
    return;
}

void StarterLogger()
{
    Console.WriteLine("- - - - - - - - - - - - - - - - ");
    Console.WriteLine(appMain);
    Console.WriteLine("- - - - - - - - - - - - - - - - ");
    Console.WriteLine("\n");
}
/*
Console.WriteLine("Please enter a valid number:");
Console.WriteLine("");

string userInput = Console.ReadLine();

if (!userInput.All(char.IsDigit))
{
    Console.WriteLine("You entered an invalid number");
}
else
{
    int parsedValidInt = int.Parse(userInput);
    Console.WriteLine(parsedValidInt * 2);
}*/


char[] bloodGroups = new char[3] {'Q','E','O'};
Console.WriteLine(bloodGroups.Length);

foreach(char c in bloodGroups)
{
    string check = c == bloodGroups[^1] ? "" : ",";

    Console.Write($"{c} {check} ");
}


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

/*
char[] bloodGroups = new char[3] {'Q','E','O'};
Console.WriteLine(bloodGroups.Length);

foreach(char c in bloodGroups)
{
    string check = c == bloodGroups[^1] ? "" : ",";

    Console.Write($"{c} {check} ");
}*/

string[,] square = new string[2, 3]
{
    {"Mohammad","Fatemeh","Ali" },
    {"Hasan","Hossein","Sajad"}
};

//Console.WriteLine(square[0,2]);

for (int i = 0; i < square.GetLength(0); i++)
{
    for (int j = 0; j < square.GetLength(1); j++)
    {
        Console.Write($" {square[i, j]} ");

        if (square[i, j] == square[0, 2])
        {
            Console.WriteLine("");
        }
    }
}

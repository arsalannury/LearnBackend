/*List<bool> flags = new List<bool>();
int[] numbers = {};
int[] numbers2 = new int[3] { 1, 2, 3 };


flags[1] = true;*/



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

/*string[,] square = new string[2, 3]
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
}*/


/*List<int> randomNumbers = new List<int>();

while (true)
{
    Console.WriteLine("Please enter a random number:");
    string randNumb = Console.ReadLine() ?? string.Empty;

    bool canParseUserInput = int.TryParse(randNumb, out int result);

    if (canParseUserInput)
    {
        randomNumbers.Add(result);
        Console.WriteLine("Random number added successfully !!");
        continue;
    }

    Console.WriteLine("Please enter valid numbers beetwen 0 to infinite");
    Console.WriteLine("");
    continue;

}*/






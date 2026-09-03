
Console.WriteLine("Enter a year to see minimum of born people at the result:");
Console.WriteLine("");

string terminal = Console.ReadLine();
bool isCommandNumber = int.TryParse(terminal, out int commandNumber);

if (isCommandNumber)
{
    var currentYear = DateTime.Now.Year;

    switch (commandNumber)
    {
        case >= 1900 and <= 1930:
            Console.WriteLine("The minimum is 467000");
            break;
        case >= 1931 and <= 1960:
            Console.WriteLine("The minimum is 29900");
            break;
        case >= 1961 and <= 1990:
            Console.WriteLine("The minimum is 52200");
            break;
        case >= 1991 and <= 2026:
            Console.WriteLine("The minimum is 2000000");
            break;
        default:
            Console.WriteLine($"Enter a year between 1900 to {new DateTime().Year}");
            break;
    }

    string conditionalCommand = commandNumber switch
    {
        >= 1900 and <= 1930 => "The minimum is 467000",
        >= 1931 and <= 1960 => "The minimum is 29900",
        >= 1961 and <= 1990 => "The minimum is 52200",
        >= 1991 and <= 2026 => "The minimum is 2000000",
        _ => $"Enter a year between 1900 to {new DateTime().Year}",
    };

}



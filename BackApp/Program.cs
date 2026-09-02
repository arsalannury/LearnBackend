
string password = Console.ReadLine() ?? string.Empty;
bool isParsedPassword = int.TryParse(password, out var parsed);

if (!isParsedPassword && parsed == 0)
{
    if (password.Trim().Length < 10)
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Select a longer password to continue");
        Console.WriteLine("-----------------------");
    } 
}
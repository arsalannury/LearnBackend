string OutputOriganizer(string command)
{
    return $"User typed a command in terminal with following details: {command}";
}


var userOut = OutputOriganizer("remove old applications from your system");
Console.WriteLine(userOut);
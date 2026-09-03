Console.WriteLine("Pick a number from 1 to 20:");

var input = Console.ReadLine();
var isInputValidNumber = int.TryParse(input,out int parsedInput);


if(isInputValidNumber)
{
    var result = parsedInput switch
    {
        > 0 and < 10 => "Not enough to pass exam",
        >= 10 and <= 15 => "Enough to pass exam but should be better than this :(",
        >= 16 and <= 20 => "Congratulations! you did the best",
        _ => "We can't recongnize what you have in this exam",
    }; 
}

/*if(isInputValidNumber)
{
    switch (parsedInput) {
        case >= 1 and <= 9:
            Console.WriteLine("Not enough to pass exam");
            break;
        case > 10 and <= 15:
            Console.WriteLine("Enough to pass exam but should be better than this :(");
            break;
        case >= 16 and <= 20:
            Console.WriteLine("Congratulations! you did the best");
            break;
        default:
            Console.WriteLine("We can't recongnize what you have in this exam");
            break;
    }
}*/
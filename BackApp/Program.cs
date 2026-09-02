bool Toggle()
{
    var @default = false;
    @default = !@default;


    return @default;
}

Console.WriteLine(Toggle());
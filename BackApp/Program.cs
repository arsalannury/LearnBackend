string name;
name = "Arsalan";

string Name;
Name = name;

string @class = "A2";

string @namespace = "BackApp"; // -> var @namespace = "BackApp";
//var variable; ---> An implicitly typed local variable must be initialized

//Console.WriteLine(@class);
//Console.WriteLine(name);
//Console.WriteLine(Name);
//Console.WriteLine("Subscription:" + 10 * 2);
//Console.WriteLine("Subscription:" + 10 + 2);
//Console.WriteLine("Subscription:" + (10 + 2));

//Test();
void Test()
{
    Console.WriteLine("TTTTest");
}


string SwitchExpression(int arg)
{
   return arg switch
    {
        <= 0 => $"Ilegall age: {arg}",
        <= 10 and > 0 => $"We prefer to don't accept: {arg}",
        <= 50 and > 10 => $"We prefer to accept with some warnings: {arg}",
        <= 100 and > 50 => $"We proud to accept some one like you: {arg}",
        _ => "Pass age",
    };
}

string resultOfExpression = SwitchExpression(90);
//Console.WriteLine(resultOfExpression);


char BloodGroup(int intiGen)
{
    return intiGen switch
    {
        > 0 and <= 5 => 'A',
        > 5 and <= 10 => 'B',
        > 10 and <= 15 => 'O',
        _ => 'N',
    };
}
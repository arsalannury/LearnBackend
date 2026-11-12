string fullName = "Arsalan Nury";
fullName = "Ardalan";
// string fullName = "";
// fullName = 2;
// fullName = true;

string title;

void Test()
{
    title = "Name";
}
Test();
// Console.WriteLine(title);


string _Test = "Test";
string test_test = "Test";
string test1 = "Test";
string @class = "Class";

int arsalan = 27;
int Arsalan = 27;

// string name, familyName, fatherName, motherName;

// string test-test = "Test";
// string 1Test = "Test";
// string class = "Test";




// Variable Precedanse
int a = 10;
int b = 25;

// Console.WriteLine("Calculate:" + a + b); // -> Calculate1025;
// Console.WriteLine("Calculate:" + a - b); // -> Compile Error;
// Console.WriteLine("Calculate:" + (a + b)); // -> Calculate35;
// Console.WriteLine("Calculate:" + (a - b)); // -> Calculate-15;
// Console.WriteLine("Calculate:" + a * b); // -> Calculate250;
// Console.WriteLine("Calculate:" + (a / b)); // -> Calculate0;

// Console.WriteLine(++b);
// Console.WriteLine(b);
// Console.WriteLine(++b);


// var fullTitle, halfTitle;
// var token = "token name";
// string userCommand = Console.ReadLine() ?? string.Empty;

// bool isUserAdmin = true;
// var condition = false;


// if (isUserAdmin)
// {
//     Console.WriteLine("Welcome Admin User. Enjoy of your power");
// }
// else
// {
//     condition = true;
//     Console.WriteLine("You are not admin. login as normal user");
// }

// string content = $"my content is {20 + 2 + 2 + 1}";
// Console.WriteLine(content);

// Console.WriteLine("Choose an option from list below");
// string userChoice = Console.ReadLine();
// bool canCanvertChoice = int.TryParse(userChoice,out int choiceNumber);

// if(canCanvertChoice)
// {
//     switch (choiceNumber)
// {
//         case 1:
//             Console.WriteLine("1 is wrong");
//             break;
//         case 2:
//             Console.WriteLine("2 is wrong");
//             break;
//         case 3:
//             Console.WriteLine("3 is correct");
//             break;
//         default:
//             Console.WriteLine("Please enter numbers between 1 to 3");
//             break;
// }
// }else
// {
//     Console.WriteLine("Please enter a valid number");
// }

// Console.WriteLine("Choose one option below to see what is waiting for you:");
// Console.WriteLine('A');
// Console.WriteLine('B');
// Console.WriteLine('C');
// Console.WriteLine('D');
// Console.WriteLine('E');
// Console.WriteLine('F');


// string userInput = Console.ReadLine();
// bool parsedInput = int.TryParse(userInput, out int parsed);

// string Calculate()
// {
//     if (!parsedInput && parsed == 0)
//     {
//         return userInput switch
//         {
//             "A" or "B" => "You have a bounes 1000$",
//             "C" => "You have a 20$ bounes",
//             "D" => "You have a 1$ bounes",
//             "F" or "E" => "You have a 12000$ bounes",
//             _ => "You don't have a bounes for now ",
//         };
//     }

//     return "Please enter valid value";
// }

// Console.WriteLine();
// Console.WriteLine(Calculate());


// string matching = userInput switch
// {
//     "A" or "B" => "You have a bounes 1000$",
//     "C" => "You have a 20$ bounes",
//     "D" => "You have a 1$ bounes",
//     _ => "You don't have a bounes for now ",
// };

int number = 0;

while (number <= 10)
{
    Console.Write($"{number}  -  ");
    number++;  
}
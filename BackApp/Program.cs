string applicationTitle = "Hello to todo app! choose an option from below list and continue \n if you want finish the app, you should enter any key";

// requirement
string[] appOptions = new string[] { "[S]how all todos", "[A]dd new todo!", "[D]elete a todo", "[U]pdate a todo", "[R]emove all todos" };
List<string> todos = new List<string>();
string newTodoContent;

Console.WriteLine(applicationTitle);

while (true)
{
    Console.WriteLine();
    foreach (var opt in appOptions)
    {
        Console.WriteLine(opt);
    }

    string userOptSelected = Console.ReadLine() ?? "";


    if (userOptSelected.ToLower() == "exit")
    {
        break;
    }


    if (userOptSelected == "S")
    {
        LoggTodos();
    }
    else if (userOptSelected == "A")
    {
        ValidateAndAddNewTodo(userOptSelected);
    }
    else if (userOptSelected == "D")
    {
        RemoveTodo();
    }
    else if (userOptSelected == "R")
    {
        RemoveAllTodos();
    }
    else if (userOptSelected == "U")
    {
        UpdateTodo();
    }
}

void ValidateAndAddNewTodo(string optSelected)
{
    Console.WriteLine();
    Console.WriteLine("Enter the todo content and press Enter:");
    newTodoContent = Console.ReadLine() ?? "";

    if (newTodoContent.Length > 0)
    {
        todos.Add(newTodoContent);
    }

    Console.WriteLine("Todo Added Successfully");
}


void RemoveTodo()
{
    Console.WriteLine("Select a todo base number to remove from list:");
    Console.WriteLine();

    LoggTodos();

    string todoToRemove = Console.ReadLine() ?? string.Empty;

    if (todoToRemove.All(char.IsDigit))
    {
        todos.RemoveAt(int.Parse(todoToRemove) - 1);
        Console.WriteLine("Todo removed successfully");
        if (todos.Count > 0)
        {
            LoggTodos();
        }
    }
}


void RemoveAllTodos()
{
    todos.Clear();
    Console.WriteLine("All todos removed !!");
    Console.WriteLine();
}


void UpdateTodo()
{
    Console.WriteLine("Select a todo base number to update:");
    Console.WriteLine();

    LoggTodos();

    string todoToUpdate = Console.ReadLine() ?? string.Empty;

    if (todoToUpdate.All(char.IsDigit))
    {

        int todoIndex = int.Parse(todoToUpdate) - 1;
        string updatedText = Console.ReadLine() ?? string.Empty;

        todos[todoIndex] = updatedText;

        Console.WriteLine("Todo updated successfully");
        LoggTodos();
    }
}


// Log all todos unconditionally
void LoggTodos()
{
    Console.WriteLine();
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}_{todos[i]}");
    }
    Console.WriteLine();
}
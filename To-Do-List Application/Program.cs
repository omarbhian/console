// Create empty list
List<String> Tasks = new List<String>();
menu:
// Welcome message
Console.WriteLine(@"Welcome To >>> To-Do-List Application
----------------------------------");
// Options menu
Console.WriteLine(@"Please choose the number :
---------------------------
1.Add task
2.View tasks
3.Remove task
----------------------------------");
// Enter Option
TryOption:
Console.Write("Enter the number you chose : ");
String Option = Console.ReadLine() ?? String.Empty;
// Option 1 (Add task)
if (Option == "1")
{
    Console.Write("\nEnter description of the task : ");
    String TaskDescription = Console.ReadLine() ?? string.Empty;
    Tasks.Add(TaskDescription);
    Console.WriteLine("Task added successfully");
    goto AskUser;
}
// Option 2 (View tasks)
else if (Option == "2")
{
    if (Tasks.Count > 0)
    {
        Console.WriteLine("\nYour tasks :\n" +
            "------------");
        for (int i = 0; i < Tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}- {Tasks[i]}");
        }
    }
    else
    {
        Console.WriteLine("\nThere is no any task ");
    }
    goto AskUser;
}
// Option 3 (Remove task)
else if (Option == "3")
{
    Console.Write("\nEnter the task number  to remove : ");
    try
    {
        int TaskNum = Convert.ToInt32(Console.ReadLine());
        Tasks.RemoveAt(TaskNum - 1);
        Console.WriteLine("Task removed successfully");
    }
    catch 
    {
        Console.WriteLine($"Invalid index, Try again");
    }
    goto AskUser;
}
// Invalid option
else
{
    Console.WriteLine("Wrong choice, Try again");
    goto TryOption;
}
// Ask user to go back to the menu or to exit from application
AskUser:
Console.Write("\n[To go back to the menu enter *][To exit enter #] : ");
String UserChoice = Console.ReadLine() ?? String.Empty;
if (UserChoice == "*")
{
    Console.Clear();
    goto menu;
}
else if (UserChoice == "#")
{
    Console.WriteLine("\nGoodbye, Have a nice day");
}
else
{
    Console.WriteLine("\nWrong choice, Try again");
    goto AskUser;
}
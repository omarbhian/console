// Variables
double Balance = 0, DepositAmount, WithdrawAmount;
// Welcome message
menu:
Console.WriteLine(@"Welcome To Bank Application
--------------------------------");
// Options menu
Console.WriteLine(@"Please choose the number :
-----------
1.Deposit
2.Withdraw
3.Exit
----------------------------------"
    );
// Enter Option
TryOption:
Console.Write("Enter the number you choce : ");
string Option = Console.ReadLine() ?? String.Empty;
// Option 1 (Deposit)
if (Option == "1")
{
    Console.Write("\nEnter amount of money to deposit : ");
    try
    {
        DepositAmount = Convert.ToDouble(Console.ReadLine());
        Balance += DepositAmount;
        Console.WriteLine("Your deposit has been successfully");
    }
    catch
    {
        Console.WriteLine("Invalid value , Try again");
    }
    goto AskUser;
}
// Option 2 (Withdraw)
else if (Option == "2")
{
    Console.Write("\nEnter amount of money to withdraw : ");
    try 
    {
        WithdrawAmount = Convert.ToDouble(Console.ReadLine());
        if (WithdrawAmount <= Balance)
        {
            Balance -= WithdrawAmount;
            Console.WriteLine("Your withdraw has been successfully");
        }
        else
        {
            Console.WriteLine("Your balance is less than withdraw amount");
        }
    }
    catch
    {
        Console.WriteLine("Invalid value, Try again");
    }
    goto AskUser;
}
// Option 3 (Exit)
else if (Option == "3")
{
    Console.WriteLine($"\nYour balance is {Balance}");
    return;
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
    Console.WriteLine($"Your balance is {Balance}");
}
else
{
    Console.WriteLine("\nWrong choice, Try again");
    goto AskUser;
}
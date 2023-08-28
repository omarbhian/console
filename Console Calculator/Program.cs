// Declare variables
double Num1, Num2;
char Op;
Start:
Console.WriteLine(@"Welcome To Your Calculator
ـــــــــــــــــــــــــــــــــــــــــــ
write Two Numbers And Choose The Operator
ـــــــــــــــــــــــــــــــــــــــــــ");
// Enter number 1
Error1:
Console.Write("write the first number : ");
try
{
    Num1 = Convert.ToDouble(Console.ReadLine());
}
catch
{
    Console.WriteLine("Error value, Try again");
    goto Error1;
}
// Enter number 2
Error2:
Console.Write("write the second number : ");
try
{
    Num2 = Convert.ToDouble(Console.ReadLine());
}
catch
{
    Console.WriteLine("Error value, Try again");
    goto Error2;
}
// Enter operator
TryOp:
Console.Write("write the operator (+,-,*,/) : ");
try
{
    Op = Convert.ToChar(Console.ReadLine());
}
catch
{
    Console.WriteLine("\nInvalid operator, Try again");
    goto TryOp;
}
// Check operator
switch (Op)
{
    case '+':
        Console.WriteLine($"\nResult of {Num1} + {Num2} = {Num1 + Num2}");
        break;
    case '-':
        Console.WriteLine($"\nResult of {Num1} - {Num2} = {Num1 - Num2}");
        break;
    case '*':
        Console.WriteLine($"\nResult of {Num1} * {Num2} = {Num1 * Num2}");
        break;
    case '/':
        if (Num2 == 0)
        {
            Console.WriteLine("\nError : Can't divide by zero");
        }
        else
        {
            Console.WriteLine($"\nResult of {Num1} / {Num2} = {Num1 / Num2}");
        }
        break;
    default:
        Console.WriteLine("\nInvalid operator. Try again");
        goto TryOp;
}
AskUser:
Console.Write("\n[To perform another operation enter *][To exit enter #] : ");
String UserChoice = Console.ReadLine() ?? String.Empty;
if (UserChoice == "*")
{
    Console.Clear();
    goto Start;
}
else if (UserChoice == "#")
{
    Console.WriteLine("\nsee you again, Thank you for using the calculator ;)");
}
else
{
    Console.WriteLine("\nWrong choice, Try again");
    goto AskUser;
}




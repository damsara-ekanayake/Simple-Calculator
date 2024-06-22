
Console.WriteLine("Hello, World!");

Console.WriteLine("Input the first number:");
var firstValue = Console.ReadLine();
int number1 = int.Parse(firstValue);

Console.WriteLine("Input the second number:");
var secondValue = Console.ReadLine();
int number2 = int.Parse(secondValue);

Console.WriteLine();

Console.WriteLine("What do you want to do with those numbers?:");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubstrat");
Console.WriteLine("[M]utiply");
string inputOperation = Console.ReadLine();

Console.WriteLine();

switch (inputOperation)
{
    case ("a") :AddNumbers(); break;
    case ("A"): AddNumbers(); break;
    case ("s"): SubstractNumbers(); break;
    case ("S"): SubstractNumbers(); break;
    case ("m"): MultiplyNumbers(); break;
    case ("M"): MultiplyNumbers(); break;
    default: Console.WriteLine("Inavalid Input!"); break;
}

void AddNumbers()
{
    int result = number1 + number2;
    Console.WriteLine( $"{number1} + {number2} = {result}");
}

void SubstractNumbers()
{
    int result = number1 - number2;
    Console.WriteLine($"{number1} - {number2} = {result}");
}

void  MultiplyNumbers()
{
    int result = number1 * number2;
    Console.WriteLine( $"{number1} * {number2} = {result}");
}

Console.WriteLine();
Console.WriteLine("Press any key to exit");
Console.ReadKey();
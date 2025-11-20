using CalculatorWithException;

int num1, num2;
Console.WriteLine("Enter two numbers: ");
Calculator calculator = new Calculator();

void LogError(string message)
{
    Console.WriteLine($"Error: {message}");
}


try
{
    num1 = Convert.ToInt32(Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter operation (+, -, *, /): ");
    string operation = Console.ReadLine();

    switch (operation)
    {
        case "+":
            calculator.Add(num1, num2);
            break;
        case "-":
            calculator.Sub(num1, num2);
            break;
        case "*":
            calculator.Mult(num1, num2);
            break;
        case "/":
            calculator.Div(num1, num2);
            break;
        default:
            Console.WriteLine("Invalid operation");
            break;
    }
}
catch(System.FormatException)
{
    LogError("Enter Number in correct format");
}
catch (System.OverflowException)
{
    LogError("Entered number is too small or large");
}
catch (DivideByZeroException ex)
{
    LogError(ex.Message);
}
finally
{
    Console.WriteLine("Calculation finished.");
}








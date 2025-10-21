
using CalculatorWithException;

int num1, num2;
Console.WriteLine("Enter two numbers: ");
Calculator calculator = new Calculator();

try
{
    num1 = Convert.ToInt32(Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());

    calculator.Add(num1, num2);
    calculator.Sub(num1, num2);
    calculator.Mult(num1, num2);
    calculator.Div(num1, num2);

}
catch(System.FormatException)
{
    Console.WriteLine("Enter Number in correct format");
}
catch (System.OverflowException)
{
    Console.WriteLine("Entered number is too small or large");
}








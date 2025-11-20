

using MathUtilities;

MathUtility mathUtility = new MathUtility();

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} is " + (mathUtility.IsEven(num)?"Even":"Odd"));
Console.WriteLine($"{num} is " + (mathUtility.IsPrime(num)?"Prime":"Not Prime"));
Console.WriteLine($"{num} factorial is " + mathUtility.fact(num));

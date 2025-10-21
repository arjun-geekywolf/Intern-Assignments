

using MathUtilities;

MathUtility mathUtility = new MathUtility();

int num = 3;

Console.WriteLine($"{num} is " + (mathUtility.IsEven(num)?"Even":"Odd"));
Console.WriteLine($"{num} is " + (mathUtility.IsPrime(num)?"Prime":"Not Prime"));
Console.WriteLine($"{num} factorial is " + mathUtility.fact(num));

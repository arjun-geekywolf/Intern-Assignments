using Assignment_02;

First20Numbers.PrintNumbers();

OddNumbers.PrintNumbers();

LargestNumber largestNumber = new LargestNumber();
largestNumber.Printlargest(2, 8, 4);

ReverseOfNumber reverse = new ReverseOfNumber();
reverse.PrintReverse(123);

sumOfDigits sumofdigits = new sumOfDigits();
sumofdigits.printSum(1111);


Console.WriteLine("\n\n\nCheck prime number\n");
PrimeCheck primecheck = new PrimeCheck();
if (primecheck.IsPrime(0))
    Console.WriteLine("Number is Prime");
else
    Console.WriteLine("Number is not prime");


PrimeBelow100 primeBelow100 = new PrimeBelow100();
primeBelow100.PrintPrimes();


Fibonacci.PrintFibonacci(10);


CalculateTax calculateTax = new CalculateTax();
calculateTax.Calculate();

SportsName sportsname  = new SportsName();
sportsname.PrintSportsName();
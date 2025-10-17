

using Assignment_03;

//ArithmeticOperations arithmetic = new ArithmeticOperations();
//arithmetic.Operations();

//EvenorOdd evenorodd=new EvenorOdd();

//Comparisons comparisons = new Comparisons();

//SwapNumbers swapNumbers = new SwapNumbers();    

//Calculator calculator = new Calculator();

//StudentData studentData = new StudentData(1000,"Arjun");
//studentData.Display();

//Employee employee = new Employee("Arjun",10000);
//employee.Display();

//Bank bank = new Bank(1234,"Arjun");
//bank.Deposit(1000);
//bank.Display();

//SwapUsingRef swap = new SwapUsingRef();
//int num1 = 10;
//int num2 = 20;
//swap.Swap(ref num1, ref num2);

//GetSumAndAvg sumAndAvg = new GetSumAndAvg();
//int sum;
//double avg;
//sumAndAvg.SumAndAvg(10, 21, out sum, out avg);
//Console.WriteLine($"Sum is {sum} and Avg is {avg}");


FindMaxMin findMaxMin = new FindMaxMin();
int[] arr = { 7, 4, 10, 2, 6, 9 };
int max, min;
findMaxMin.MaxMin(arr, out min, out max);
Console.WriteLine($"Min = {min} and Max = {max}");


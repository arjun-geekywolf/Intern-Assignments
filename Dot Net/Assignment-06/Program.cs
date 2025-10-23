
using Assignment_06;
//-----------------------Question 1-----------------------
//ArrayListOperations arrayListOperations = new ArrayListOperations();
//arrayListOperations.operations();


//-----------------------Question 2-----------------------
//MixedDataTypes mixedDataTypes = new MixedDataTypes();
//mixedDataTypes.mixed();


//-----------------------Question 3-----------------------
//GenericsWithList genericsWithList = new GenericsWithList();
//genericsWithList.generics();


//-----------------------Question 4-----------------------
//Books book1 = new Books("title1","author1",100);
//Books book2 = new Books("title2", "author2", 500);
//Books book3 = new Books("title3", "author3", 300);

//List<Books> books= new List<Books>();

//books.Add(book1);
//books.Add(book2);
//books.Add(book3);

//Console.WriteLine("All books");
//foreach(Books book in books)
//{
//    book.BookDetails();
//}

//Books expensiveBook = books.OrderByDescending(book=>book.price).FirstOrDefault();


//Console.WriteLine("\nBook with the highest Price");
//expensiveBook.BookDetails();

//Books bookToRemove = books.FirstOrDefault(books => books.title == "title1");

//books.Remove(bookToRemove);
//Console.WriteLine("Book Removed");


//Console.WriteLine("\nBooks after removal");
//foreach (Books book in books)
//{
//    book.BookDetails();
//}



//Question 5

//ListString listString = new ListString();

//listString.namesStartWithA();
//listString.lengthGreaterThan4();


//Employee e1 = new Employee("arjun", 10000, "Permanent");


//e1.Display();
//e2.Display();

List<Employee> employees = new List<Employee>();
EmployeeCollection employeeCollection = new EmployeeCollection();

//employeeCollection.AddEmployee();
//employeeCollection.AddEmployee();
//employeeCollection.DisplayAll();
//employeeCollection.Search();
//employeeCollection.RemoveEmployee();


bool flag = true;
string option;

while (flag)
{
    Console.WriteLine("\n\nWelcome to the Employee Management System…\r\nPlease choose one of the following:\r\n1.Add Employee\r\n2.Remove Employee\r\n3.Display All Employees\r\n4.Search Employee\r\n5.Exit\r\n");
    option = Console.ReadLine();


    switch (option)
    {
        case "1": employeeCollection.AddEmployee(); break;
        case "2": employeeCollection.RemoveEmployee(); break;
        case "3": employeeCollection.DisplayAll(); break;
        case "4": employeeCollection.Search(); break;
        case "5": flag = false; break;
        default: Console.WriteLine("Invalid option"); break;
    }

}





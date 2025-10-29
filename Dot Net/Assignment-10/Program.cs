// See https://aka.ms/new-console-template for more information
using Banking2;

Console.WriteLine("Hello, World!");


Customer customer1 = new Customer();
Customer customer2 = new Customer();
Customer customer3 = new Customer();

Address address1 = new Address();
Address address2 = new Address();
Address address3 = new Address();


Account account1 = new Account();
Account account2 = new Account();
Account account3 = new Account();
Account account4 = new Account();


address1.Street = "street1";
address1.City = "city1";
address1.Country = "country1";
address1.State = "state1";
address1.PostalCode = "1234";

address2.Street = "street2";
address2.City = "city2";
address2.Country = "country2";
address2.State = "state2";
address2.PostalCode = "1234";

address3.Street = "street3";
address3.City = "city3";
address3.Country = "country3";
address3.State = "state3";
address3.PostalCode = "1234";



customer1.Email = "email1@g.com";
customer1.FullName = "fulname1";
customer1.DateOfBirth = DateTime.Parse("21-04-2002");
customer1.Address = address1;
customer1.PhoneNumber = "9876543210";
customer1.Accounts= new List<Account> { account1};



customer2.Email = "email2@g.com";
customer2.FullName = "fulname2";
customer2.DateOfBirth = DateTime.Parse("21-04-2002");
customer2.Address = address2;
customer2.PhoneNumber = "9876543210";
customer2.Accounts= new List<Account> { account2};

customer3.Email = "email3@g.com";
customer3.FullName = "fulname3";
customer3.DateOfBirth = DateTime.Parse("21-04-2002");
customer3.Address = address3;
customer3.PhoneNumber = "9876543210";
customer3.Accounts= new List<Account> { account3 };



account1.Balance = 100;
account1.AccountNumber = "1001";


account2.Balance = 200;
account2.AccountNumber="1002";



account3.Balance = 300;
account3.AccountNumber="1003";


account4.Balance = 400;
account4.AccountNumber = "1004";




AccountOperations operations = new AccountOperations();

//operations.add(customer1);
//operations.add(customer2);
//operations.add(customer3);

operations.DisplayAll();

operations.DeleteAccount(1015,1014);

operations.DisplayAll();






using Banking_EFCore;

Console.WriteLine("hello");

BankingAppDbContext context = new BankingAppDbContext();

Customer customer = new Customer();

var customers = new List<Customer>
{
	new Customer
	{
		FullName = "John Smith",
		Email = "john.smith@email.com",
		PhoneNumber = "-857",
		DateOfBirth = DateTime.Parse("1987-04-12"),
		Address = "123 Main St, New York, USA",
		CreatedDate = DateTime.Parse("2025-01-01")
	},
	new Customer
	{
		FullName = "Maria Gonzalez",
		Email = "maria.gonzalez@gmail.com",
		PhoneNumber = "-1601",
		DateOfBirth = DateTime.Parse("1990-08-25"),
		Address = "45 Calle Mayor, Madrid, Spain",
		CreatedDate = DateTime.Parse("2025-02-15")
	},
	new Customer
	{
		FullName = "Liam O'Connor",
		Email = "liam.oconnor@outlook.com",
		PhoneNumber = "-907779",
		DateOfBirth = DateTime.Parse("1985-11-03"),
		Address = "89 Abbey Rd, London, UK",
		CreatedDate = DateTime.Parse("2025-03-10")
	},
	new Customer
	{
		FullName = "Sophia Müller",
		Email = "sophia.mueller@gmail.com",
		PhoneNumber = "-2345780",
		DateOfBirth = DateTime.Parse("1992-07-18"),
		Address = "22 Berliner Str, Berlin, Germany",
		CreatedDate = DateTime.Parse("2025-04-05")
	},
	new Customer
	{
		FullName = "Ethan Brown",
		Email = "ethan.brown@yahoo.com",
		PhoneNumber = "-1374",
		DateOfBirth = DateTime.Parse("1989-02-14"),
		Address = "17 King St, Sydney, Australia",
		CreatedDate = DateTime.Parse("2025-05-01")
	}
};
context.Customers.AddRange(customers);

context.SaveChanges();


AccountOperations operations = new AccountOperations();

operations.Add(customer1);

operations.Update(2, "new address");
operations.Delete(7);

operations.Display(8);




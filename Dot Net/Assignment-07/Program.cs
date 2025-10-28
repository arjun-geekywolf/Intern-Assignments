using Assignment_07;
using Assignment_07.Q05_Bank;

////-----------------------------Question 1-----------------------------
//string str = "how are you";
//Console.WriteLine(str.ToTitleCase());


////-----------------------------Question 2-----------------------------
//List<int> numbers = new List<int> { 0, 0, 0, 0, 0 };
//Console.WriteLine(numbers.AverageExceptZero());

////-----------------------------Question 3-----------------------------
//Animal animal = new Animal();
//Dog dog = new Dog();
//Cat cat = new Cat();

//animal.speak();
//dog.speak();
//cat.speak();


////-----------------------------Question 4-----------------------------

//Vehicle v = new Vehicle();
//v.ShowType();

//Car c = new Car();
//c.ShowType();

//Vehicle vc= new Car();
//vc.ShowType();


////-----------------------------Question 5-----------------------------
//IAccount savingsAccount = new SavingsAccount();

//savingsAccount.Deposit(1000);
//savingsAccount.Withdraw(500);
//Console.WriteLine($"Balance:{savingsAccount.GetBalance()}");

//IAccount currentAccount = new CurrentAccount();
//currentAccount.Deposit(2000);
//currentAccount.Withdraw(700);
//Console.WriteLine($"Balance:{currentAccount.GetBalance()}");

//IPaymentService card = new CardPayment();
//PaymentProcessor cardProcessor = new PaymentProcessor(card);
//cardProcessor.process(2000);

//IPaymentService upi = new UPIPayment();
//PaymentProcessor upiProcessor = new PaymentProcessor(upi);
//upiProcessor.process(1000);

//IPaymentService netBank = new NetBankingPayment();
//PaymentProcessor paymentProcessor = new PaymentProcessor(netBank);
//paymentProcessor.process(1000);


//-----------------------------Question 6-----------------------------

INotificationService sms = new SMSNotifier();
INotificationService email = new EmailNotifier();
INotificationService push = new PushNotification();


AppointmentService smsAppointment = new AppointmentService(sms);
AppointmentService emailAppointment = new AppointmentService(email);
AppointmentService pushAppointment = new AppointmentService(push);

string msg = "Your appoointment is confirmed";

smsAppointment.Send(msg);
emailAppointment.Send(msg);
pushAppointment.Send(msg);
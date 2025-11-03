using BusinessLogic;


BusinessLogic.BusinessLogic logic = new BusinessLogic.BusinessLogic();

if (logic.Business())
    Console.WriteLine("Business Logic called from UI");
else
    Console.WriteLine("Business Logic call failed");


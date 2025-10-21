using DataAccess;


namespace BusinessLogic
{
    public class BusinessLogic
    {
        DataAccess.DataAccess access = new DataAccess.DataAccess();
        public bool Business()
        {
            if (access.connection())
            {
                Console.WriteLine("Business logic applied");
                return true;
            }
            return false;

        }
    }
}

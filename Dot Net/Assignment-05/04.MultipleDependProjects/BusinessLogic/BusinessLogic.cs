using DataAccess;


namespace BusinessLogic
{
    public class BusinessLogic
    {
        DataAccess.DataAccess access = new DataAccess.DataAccess();
        public bool Business()
        {
            string result = access.GetData();

            return result.Contains("success");
        }
    }
}

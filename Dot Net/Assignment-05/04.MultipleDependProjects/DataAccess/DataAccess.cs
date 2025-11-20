namespace DataAccess
{
    public class DataAccess
    {
        public bool connection()
        {
            Console.WriteLine("Database Connected");
            return true;
        }

        public string GetData()
        {
            return "Data fetched successfully";
        }
    }
}

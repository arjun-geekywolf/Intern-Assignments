namespace Hotel_Booking_System.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}

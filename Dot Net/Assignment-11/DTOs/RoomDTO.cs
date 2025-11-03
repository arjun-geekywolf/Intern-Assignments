using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTOs
{
    public class RoomDTO
    {
        public string RoomNumber { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public RoomStatus Status { get; set; }
        public decimal PricePerNight { get; set; }
    }
}

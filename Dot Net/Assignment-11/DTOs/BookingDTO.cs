using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.DTOs
{
    public class BookingDTO
    {
        public int CustomerId { get; set; }

        public int RoomId { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public BookingStatus Status { get; set; }

        public decimal TotalAmount { get; set; }

    }
}

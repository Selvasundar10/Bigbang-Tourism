using Bigbang_Tourism.Models;

namespace Booking_API.Repository.Interface
{
    public interface IBooking_Details
    {
        public Task<List<Booking_Details>> GetBooking_Details();

        public Task<Booking_Details> PostBooking_Details(Booking_Details booking);

    }
}

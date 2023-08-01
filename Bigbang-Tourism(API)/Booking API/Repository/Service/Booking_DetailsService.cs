using Bigbang_Tourism.Models;
using Booking_API.DB;
using Booking_API.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Booking_API.Repository.Service
{
    public class Booking_DetailsService : IBooking_Details
    {
        private readonly BookingContext _context;

        public Booking_DetailsService(BookingContext context)
        {
            _context = context;
        }

        public async Task<List<Booking_Details>> GetBooking_Details()
        {
            return await _context.Booking_Details.ToListAsync();
        }

        public async Task<Booking_Details> PostBooking_Details(Booking_Details booking)
        {
            _context.Booking_Details.Add(booking);
            await _context.SaveChangesAsync();
            return booking;

        }
    }
}

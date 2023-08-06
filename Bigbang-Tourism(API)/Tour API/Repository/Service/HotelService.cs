using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using Tour_API.DB;
using Tour_API.Repository.Interface;

namespace Tour_API.Repository.Service
{
    public class HotelService : IHotelService
    {

        private readonly TourContext _context;

        public HotelService(TourContext context)
        {
            _context = context;
        }

        public async Task<List<Hotel>> GetHotel()
        {
            return await _context.Hotel.ToListAsync();
        }

        public async Task<Hotel> GetHotelById(int id)
        {
            var doc = await _context.Hotel.FirstOrDefaultAsync(x => x.Hotel_Id == id);
            return doc;
        }

        public async Task<Hotel> PostHotel(Hotel hotel)
        {
            _context.Hotel.Add(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task<Hotel> PutHotel(string name, Hotel hotel)
        {
            var _hotel = await _context.Hotel.FirstOrDefaultAsync(x => x.Hotel_Name == name);
            if (_hotel == null)
            {
                return null;
            }

            _hotel.Hotel_Name = hotel.Hotel_Name;
            _hotel.Location = hotel.Location;
            _hotel.Contact_Details = hotel.Contact_Details;
            _hotel.Rating = hotel.Rating;

            _hotel.ImageURL = hotel.ImageURL;
            _hotel.Description = hotel.Description;



            _context.Entry(_hotel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _hotel;
        }

        public async Task<string> DeleteHotel(string name)
        {
            var doc = await _context.Hotel.FirstOrDefaultAsync(x => x.Hotel_Name == name);
            if (doc == null)
            {
                return null;
            }
            _context.Hotel.Remove(doc);
            await _context.SaveChangesAsync();
            return "Feedback Deleted Successfully";
        }
        public async Task<List<Hotel>> FilterByLocation(string location)
        {
            var Hotels = _context.Hotel.Where(x=> x.Location ==location);

            return await Hotels.ToListAsync();

        }
             public async Task<List<Hotel>> FilterByHotelName(string hotel_name)
        {
            var Hotels = _context.Hotel.Where(x=> x.Hotel_Name ==hotel_name);

            return await Hotels.ToListAsync();

        }

    }
}

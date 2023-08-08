using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using Tour_API.DB;
using Tour_API.Repository.Interface;

namespace Tour_API.Repository.Service
{
    public class HotelService : IHotelService
    {

        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly TourContext _context;


        public HotelService(TourContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;

        }

        public async Task<List<Hotel>> GetHotel()
        {
            return await _context.Hotel.Include(x => x.Tour).ToListAsync();
        }

    

        public async Task<Hotel> PostHotel([FromForm] Hotel hotel, IFormFile imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                throw new ArgumentException("Invalid file");
            }
            var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images/Tour");
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
            var filePath = Path.Combine(uploadsFolder, fileName);
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                var tour = await _context.Tour.FirstOrDefaultAsync(x => x.Tour_Id == hotel.Tour.Tour_Id);
                hotel.Tour = tour;
                _context.Hotel.Add(hotel);
                await _context.SaveChangesAsync();
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while posting the Hotel.", ex);
            }
        }

        public async Task<Hotel> PutHotel(string name, Hotel hotel)
        {
            var _hotel = await _context.Hotel.FirstOrDefaultAsync(x => x.Hotel_name == name);
            if (_hotel == null)
            {
                return null;
            }

            _hotel.Hotel_name = hotel.Hotel_name;
            _hotel.Location = hotel.Location;
            _hotel.Contact_details = hotel.Contact_details;
            _hotel.Rating = hotel.Rating;

            _hotel.ImageURL = hotel.ImageURL;
            _hotel.Description = hotel.Description;



            _context.Entry(_hotel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _hotel;
        }

        public async Task<string> DeleteHotel(string name)
        {
            var doc = await _context.Hotel.FirstOrDefaultAsync(x => x.Hotel_name == name);
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
            var Hotels = _context.Hotel.Where(x=> x.Hotel_name ==hotel_name);

            return await Hotels.ToListAsync();

        }

    }
}

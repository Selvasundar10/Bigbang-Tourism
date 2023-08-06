using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using Tour_API.DB;
using Tour_API.Repository.Interface;

namespace Tour_API.Repository.Service
{
    public class TourService : ITour
    {
        private readonly TourContext _context;

        public TourService(TourContext context)
        {
            _context = context;
        }

        public async Task<List<Tour>> GetTour()
        {
            return await _context.Tour.ToListAsync();
        }

        public async Task<Tour> GetTourDetails(int id)
        {
            var doc = await _context.Tour.FirstOrDefaultAsync(x => x.Tour_Id == id);
            return doc;
        }

        public async Task<Tour> PostTour(Tour tour)
        {
            _context.Tour.Add(tour);
            await _context.SaveChangesAsync();
            return tour;
        }

        public async Task<Tour> PutTour(string name, Tour tour)
        {
            var existingTour = await _context.Tour.FirstOrDefaultAsync(x => x.Tour_Name == name);
            if (existingTour == null)
            {
                return null;
            }

            existingTour.Tour_Name = tour.Tour_Name;
            existingTour.Duration = tour.Duration;
            existingTour.Itinerary = tour.Itinerary;
            existingTour.Tour_Location = tour.Tour_Location;

            _context.Entry(existingTour).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return existingTour;
        }

        public async Task<string> DeleteTour(string name)
        {
            var doc = await _context.Tour.FirstOrDefaultAsync(x => x.Tour_Name == name);
            if (doc == null)
            {
                return null;
            }
            _context.Tour.Remove(doc);
            await _context.SaveChangesAsync();
            return "Deleted Successfully";
        }
        public async Task<List<Tour>> FilterByTourLocation(string location)
        {
            var Tours = _context.Tour.Where(x => x.Tour_Location == location);

            return await Tours.ToListAsync();
        }



        public async Task<List<Tour>> FilterByDays(string days)
        {
            var query = _context.Tour.AsQueryable();

            // Filter the tours based on the number of days
            query = query.Where(tour => tour.Duration == days);

            return await query.ToListAsync();
        }
        public async Task<List<Tour>> FilterByTourPrice(decimal minprice, decimal maxprice)
        {
            var query = _context.Tour.AsQueryable();
            query = query.Where(tour => tour.Cost >= minprice && tour.Cost <= maxprice);

            return await query.ToListAsync();
        }
    }
}

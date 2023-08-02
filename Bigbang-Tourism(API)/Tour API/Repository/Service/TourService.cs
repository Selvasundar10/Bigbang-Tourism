using Bigbang_Tourism.Models;
using Microsoft.EntityFrameworkCore;
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
            return await _context.Feedbacks.ToListAsync();
        }

        public async Task<Tour> GetTourDetails(int id)
        {
            var doc = await _context.Feedbacks.FirstOrDefaultAsync(x => x.Tour_Id == id);
            return doc;
        }

        public async Task<Tour> PostTour(Tour tour)
        {
            _context.Feedbacks.Add(tour);
            await _context.SaveChangesAsync();
            return tour;
        }

        public async Task<Tour> PutTour(int id, Tour tour)
        {
            var existingTour = await _context.Feedbacks.FirstOrDefaultAsync(x => x.Tour_Id == tour.Tour_Id);
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

        public async Task<string> DeleteTour(int id)
        {
            var doc = await _context.Feedbacks.FirstOrDefaultAsync(x => x.Tour_Id == id);
            if (doc == null)
            {
                return null;
            }
            _context.Feedbacks.Remove(doc);
            await _context.SaveChangesAsync();
            return "Deleted Successfully";
        }
    }
}

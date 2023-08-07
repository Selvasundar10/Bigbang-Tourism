using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using Tour_API.DB;
using Tour_API.Repository.Interface;

namespace Tour_API.Repository.Service
{
    public class ItineraryService : IItinerary
    {
        private readonly TourContext _context;

        public ItineraryService(TourContext context)
        {
            _context = context;
        }

        public async Task<List<Itinerary>> GetItinerary()
        {
            return await _context.Itinerary.Include(x=>x.Tour).ToListAsync();
        }

     

        public async Task<Itinerary> PostItinerary(Itinerary itinerary)
        {
           
            var tour=await _context.Tour.FirstOrDefaultAsync(x=>x.Tour_Id==itinerary.Tour.Tour_Id);
            itinerary.Tour=tour;
            _context.Itinerary.Add(itinerary);
            await _context.SaveChangesAsync();
            return itinerary;
        }

        public async Task<Itinerary> PutItinerary(int id, Itinerary itinerary)
        {
            var _itinerary = await _context.Itinerary.FirstOrDefaultAsync(x => x.Itinerary_Id == id);
            if (_itinerary == null)
            {
                return null;
            }

            _itinerary.Days = itinerary.Days;
            _itinerary.Activities = itinerary.Activities;
     
            _context.Entry(_itinerary).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _itinerary;
        }

        public async Task<string> DeleteItinerary(int id)
        {
            var doc = await _context.Itinerary.FirstOrDefaultAsync(x => x.Itinerary_Id == id);
            if (doc == null)
            {
                return null;
            }
            _context.Itinerary.Remove(doc);
            await _context.SaveChangesAsync();
            return "Itinerary Deleted Successfully";
        }
       

    }
}

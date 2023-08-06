using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using Tour_API.DB;
using Tour_API.Repository.Interface;

namespace Tour_API.Repository.Service
{
    public class TourSpotService : ITourSpot
    {
        private readonly TourContext _context;

        public TourSpotService(TourContext context)
        {
            _context = context;
        }

        public async Task<List<TourSpot>> GetTourSpot()
        {
            return await _context.TourSpots.ToListAsync();
        }


        public async Task<TourSpot> PostTourSpot(TourSpot tourspot)
        {
            _context.TourSpots.Add(tourspot);
            await _context.SaveChangesAsync();
            return tourspot;
        }

        public async Task<TourSpot> PutTourSpot(string name, TourSpot tourspot)
        {
            var Tourspot = await _context.TourSpots.FirstOrDefaultAsync(x => x.SpotName == name);
            if (Tourspot == null)
            {
                return null;
            }

            Tourspot.SpotName = tourspot.SpotName;
            Tourspot.Location = tourspot.Location;
            Tourspot.Specialty = tourspot.Specialty;
            Tourspot.ImageURL = tourspot.ImageURL;



            _context.Entry(Tourspot).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Tourspot;
        }

        public async Task<string> DeleteTourSpot(string name)
        {
            var doc = await _context.TourSpots.FirstOrDefaultAsync(x => x.SpotName == name);
            if (doc == null)
            {
                return null;
            }
            _context.TourSpots.Remove(doc);
            await _context.SaveChangesAsync();
            return "Deleted Successfully";
        }
      /*  public async Task<List<Tour>> FilterByTourLocation(string location)
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
        }*/
    }
}

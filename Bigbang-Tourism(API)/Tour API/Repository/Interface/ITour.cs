using Microsoft.EntityFrameworkCore;
using ModelsLibrary;

namespace Tour_API.Repository.Interface
{
    public interface ITour
    {
        public Task<List<Tour>> GetTour();
        public Task<Tour> GetTourDetails(int id);

        public Task<Tour> PostTour(Tour tour);
        public Task<Tour> PutTour(string name, Tour tour);

        public Task<string> DeleteTour(string name);
        public Task<List<Tour>> FilterByTourLocation(string location);
        public Task<List<Tour>> FilterByTourPrice(decimal minprice, decimal maxprice);
        public Task<List<Tour>> FilterByDays(string days);


    }
}

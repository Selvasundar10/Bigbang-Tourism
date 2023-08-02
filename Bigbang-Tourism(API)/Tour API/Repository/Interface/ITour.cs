using Bigbang_Tourism.Models;
using Microsoft.EntityFrameworkCore;

namespace Tour_API.Repository.Interface
{
    public interface ITour
    {
        public Task<List<Tour>> GetTour();
        public Task<Tour> GetTourDetails(int id);

        public Task<Tour> PostTour(Tour tour);
        public Task<Tour> PutTour(int id, Tour tour);

        public Task<string> DeleteTour(int id);

    }
}

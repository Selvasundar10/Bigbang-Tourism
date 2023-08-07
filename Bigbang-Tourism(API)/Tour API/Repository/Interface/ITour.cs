using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using Tour_API.DTO;

namespace Tour_API.Repository.Interface
{
    public interface ITour
    {
        public Task<List<Tour>> GetTour();
        public Task<Tour> GetTourDetails(int id);

        public Task<Tour> PostTour([FromForm] Tour tour, IFormFile imageFile);
        public Task<Tour> PutTour(string name, Tour tour);

        public Task<string> DeleteTour(string name);
        public Task<List<Tour>> FilterByTourLocation(string location);
        public Task<List<Tour>> FilterByTourPrice(decimal minprice, decimal maxprice);
        public Task<List<Tour>> FilterByDays(string days);
        public Task<TourDTO> RegisterTour(TourDTO tourDTO);


    }
}

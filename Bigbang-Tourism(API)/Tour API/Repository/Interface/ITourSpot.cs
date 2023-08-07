using Microsoft.AspNetCore.Mvc;
using ModelsLibrary;

namespace Tour_API.Repository.Interface
{
    public interface ITourSpot
    {
        public Task<List<TourSpot>> GetTourSpot();
        public Task<TourSpot> PostTourSpot([FromForm] TourSpot tourspot, IFormFile imageFile);
        public Task<TourSpot> PutTourSpot( String name, TourSpot tourspot  );
        public Task<string> DeleteTourSpot(string name);

    }
}

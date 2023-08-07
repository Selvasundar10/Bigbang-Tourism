using Microsoft.AspNetCore.Mvc;
using ModelsLibrary;

namespace Tour_API.Repository.Interface
{
    public interface IHotelService
    {
        public Task<List<Hotel>> GetHotel();
        public Task<Hotel> PostHotel( Hotel hotel);
        public Task<Hotel> PutHotel(string name, Hotel hotel);
        public Task<string> DeleteHotel(string name);
        public Task<List<Hotel>> FilterByLocation(string location);

        public Task<List<Hotel>> FilterByHotelName(string hotel_name);


    }
}

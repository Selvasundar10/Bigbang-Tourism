using ModelsLibrary;

namespace Tour_API.Repository.Interface
{
    public interface IItinerary
    {
        public Task<List<Itinerary>> GetItinerary();

        public Task<Itinerary> PostItinerary(Itinerary Itinerary);
        public Task<Itinerary> PutItinerary(int id, Itinerary Itinerary);

        public Task<string> DeleteItinerary(int id);
      
    }
}

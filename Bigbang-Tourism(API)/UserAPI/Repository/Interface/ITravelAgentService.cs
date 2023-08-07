using Microsoft.AspNetCore.Mvc;
using ModelsLibrary;
using UserAPI.DTO;

namespace UserAPI.Repository.Interface
{
    public interface ITravelAgentService
    {
        public Task<List<Travel_Agent>> GetTravelAgent();
        public Task<ActionResult<Travel_Agent>> GetTravelAgent(string id);

        public Task<Travel_Agent> PutTravelAgent(string id, Travel_Agent travelAgent);
        public Task<Travel_Agent> PostTravelAgent(Travel_Agent travelAgent);
        public Task<String> DeleteTravelAgent(string id);



    }
}
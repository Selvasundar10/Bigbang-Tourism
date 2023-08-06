using System.Collections.Generic;
using UserAPI.DTO;
using UserAPI.Repository.Interface;

namespace UserAPI.Repository.Service
{
    public class TravelAgentService : ITravelAgentService
    {
        private static readonly List<UserDTO> _travelAgents = new List<UserDTO>();

        public void AddTravelAgent(UserDTO userDto)
        {
            _travelAgents.Add(userDto);
        }
    }
}

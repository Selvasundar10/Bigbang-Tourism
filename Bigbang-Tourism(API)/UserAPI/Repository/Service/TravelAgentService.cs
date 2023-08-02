using Bigbang_Tourism.DTOs;
using Bigbang_Tourism.Interfaces;
using System.Collections.Generic;

namespace Bigbang_Tourism.Services
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

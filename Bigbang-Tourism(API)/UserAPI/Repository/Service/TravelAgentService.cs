using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using System.Collections.Generic;
using UserAPI.DB;
using UserAPI.DTO;
using UserAPI.Repository.Interface;

namespace UserAPI.Repository.Service
{
    public class TravelAgentService : ITravelAgentService
    {
        private readonly UserContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public TravelAgentService(UserContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
        }
        public async Task<List<Travel_Agent>> GetTravelAgent()
        {
            return await _context.Travel_Agent.ToListAsync();
        }


        public async Task<ActionResult<Travel_Agent>> GetTravelAgent(string id)
        {
            var agent = await _context.Travel_Agent.FirstOrDefaultAsync(x => x.Agent_Id == id);
            if (agent == null)
            {
                return null;
            }
            return agent;
        }
        public async Task<Travel_Agent> PutTravelAgent(string id, Travel_Agent travelAgent)
        {
            var agent = await _context.Travel_Agent.FirstOrDefaultAsync(x => x.Agent_Id == id);
            if (agent == null)
            {
                return null;
            }
            agent.RequestStatus = travelAgent.RequestStatus;
            _context.SaveChanges();
            return travelAgent;
        }
        public async Task<Travel_Agent> PostTravelAgent( Travel_Agent travelAgent)
        {
            _context.Travel_Agent.Add(travelAgent);
            await _context.SaveChangesAsync();
            return travelAgent;


        }

        public async Task<String> DeleteTravelAgent(string id)
        {
            var agent = await _context.Travel_Agent.FirstOrDefaultAsync(x => x.Agent_Id == id);
            if (agent == null)
            {
                return null;
            }
            _context.Travel_Agent.Remove(agent);
            _context.SaveChanges();

            return "Travel Agent Deleted Successfully!!!";
        }


    }
}

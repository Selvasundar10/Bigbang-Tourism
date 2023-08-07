using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using UserAPI.DB;
using UserAPI.Repository.Interface;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelAgentsController : ControllerBase
    {
        private readonly ITravelAgentService _context;

        public TravelAgentsController(ITravelAgentService context)
        {
            _context = context;
        }

        // GET: api/TravelAgents
        [HttpGet]
        public async Task<List<Travel_Agent>> GetTravelAgent()
        {

            return await _context.GetTravelAgent();
        }

        // GET: api/TravelAgents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Travel_Agent>> GetTravelAgent(string id)
        {


            return await _context.GetTravelAgent(id);
        }

        // PUT: api/TravelAgents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<Travel_Agent> PutTravelAgent(string id, Travel_Agent travelAgent)
        {


            return await _context.PutTravelAgent(id, travelAgent);
        }

        // POST: api/TravelAgents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Travel_Agent> PostTravelAgent(Travel_Agent travelAgent)
        {


            return await _context.PostTravelAgent(travelAgent);
        }

        // DELETE: api/TravelAgents/5
        [HttpDelete("{id}")]
        public async Task<String> DeleteTravelAgent(string id)
        {


            return await _context.DeleteTravelAgent(id);
        }
    }
}
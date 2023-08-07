using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using Tour_API.DB;
using Tour_API.Repository.Interface;

namespace Tour_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItinerariesController : ControllerBase
    {

        private readonly IItinerary _context;

        public ItinerariesController(IItinerary context)
        {
            _context = context;
        }

        // GET: api/Itinerary
        [HttpGet]
        public async Task<List<Itinerary>> GetItinerary()
        {

            return await _context.GetItinerary();
        }



        // POST: api/Itinerary
        [HttpPost]
        public async Task<Itinerary> PostItinerary(Itinerary itinerary)
        {

            return await _context.PostItinerary(itinerary);
        }

        // PUT: api/Itinerary/5
        [HttpPut("{id}")]
        public async Task<Itinerary> PutItinerary(int id, Itinerary itinerary)
        {


            return await _context.PutItinerary(id, itinerary);
        }


        // DELETE: api/Itinerary/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteItinerary(int id)
        {


            return await _context.DeleteItinerary(id);
        }

    }
    }

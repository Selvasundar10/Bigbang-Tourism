using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tour_API.DB;
using Microsoft.Extensions.Hosting;
using Tour_API.Repository.Interface;
using ModelsLibrary;

namespace Tour_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelService _context;

        public HotelsController(IHotelService context)
        {
            _context = context;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<List<Hotel>> GetHotel()
        {
            return await _context.GetHotel();
        }



        // POST: api/Tours
        [HttpPost]
        public async Task<Hotel> PostHotel([FromForm] Hotel hotel, IFormFile imageFile)
        {

            return await _context.PostHotel(hotel, imageFile);
        }
        // PUT: api/Tours/5
        [HttpPut("{name}")]
        public async Task<Hotel> PutHotel(string name, Hotel hotel)
        {


            return await _context.PutHotel(name, hotel);
        }


        // DELETE: api/Tours/5
        [HttpDelete("{name}")]
        public async Task<string> DeleteHotel(string name)
        {

            return await _context.DeleteHotel(name);
        }
     /*   [HttpGet("filterByLocation/{location}")]
        public async Task<List<Hotel>> FilterByLocation(string location)
        {
            return await _context.FilterByLocation(location);
        }

        [HttpGet("filterByLocation/{HotelName}")]
        public async Task<List<Hotel>> FilterByHotelName(string hotel_name)
        {
            return await _context.FilterByHotelName(hotel_name);
        }*/
    
    }
}

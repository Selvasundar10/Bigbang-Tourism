using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tour_API.DB;
using ModelsLibrary;
using Tour_API.Repository.Interface;

namespace Tour_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourSpotsController : ControllerBase
    {
        private readonly ITourSpot _context;

        public TourSpotsController(ITourSpot context)
        {
            _context = context;
        }

        // GET: api/TourSpot
        [HttpGet]
        public async Task<List<TourSpot>> GetTourSpot()
        {

            return await _context.GetTourSpot();
        }



        // POST: api/TourSpot
        [HttpPost]
        public async Task<TourSpot> PostTourSpot([FromForm]  TourSpot tourspot,Tour tour, IFormFile imageFile)
        {

            return await _context.PostTourSpot(tourspot, imageFile);
        }
        // PUT: api/TourSpot/5
        [HttpPut("{name}")]
        public async Task<TourSpot> PutTourSpot(String name, TourSpot tourspot)
        {


            return await _context.PutTourSpot(name, tourspot);
        }


        // DELETE: api/Tourspot/5
        [HttpDelete("{name}")]
        public async Task<string> DeleteTourSpot(string name)
        {


            return await _context.DeleteTourSpot(name);
        }

   /*     [HttpGet("filterByLocation/{location}")]
        public async Task<List<Tour>> FilterByTourLocation(string location)
        {
            return await _context.FilterByTourLocation(location);
        }
        [HttpGet("FilterByPrice/{minprice}/{maxprice}")]
        public async Task<List<Tour>> FilterByTourPrice(decimal minprice, decimal maxprice)
        {
            return await _context.FilterByTourPrice(minprice, maxprice);
        }

        [HttpGet("FilterByDays/{days}")]
        public async Task<List<Tour>> FilterByDays(string days)
        {
            return await _context.FilterByDays(days);
        }*/


    }
}

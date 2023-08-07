using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tour_API.DB;
using Tour_API.Repository.Service;
using Tour_API.Repository.Interface;
using ModelsLibrary;
using System.Drawing;
using Tour_API.DTO;

namespace Tour_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly ITour _context;

        public ToursController(ITour context)
        {
            _context = context;
        }

        // GET: api/Tours
        [HttpGet]   
        public async Task<List<Tour>> GetTour()
        {

            return await _context.GetTour();
        }



        // POST: api/Tours
        [HttpPost]
        public async Task<Tour> PostTour([FromForm]Tour tour, IFormFile imageFile)
        {

            return await _context.PostTour(tour, imageFile);
        }

        // PUT: api/Tours/5
        [HttpPut("{name}")]
        public async Task<Tour> PutTour(String name, Tour tour)
        {


            return await _context.PutTour(name, tour);
        }


        // DELETE: api/Tours/5
        [HttpDelete("{name}")]
        public async Task<string> DeleteTour(string name)
        {


            return await _context.DeleteTour(name);
        }

        [HttpGet("filterByLocation/{location}")]
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
        }
        [HttpPost("PostPackage")]
        public async Task<TourDTO> RegisterTour(TourDTO tourDTO)

        {

            return await _context.RegisterTour(tourDTO);
        }

    }
}

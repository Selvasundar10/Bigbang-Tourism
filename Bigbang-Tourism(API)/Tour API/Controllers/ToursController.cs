using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bigbang_Tourism.Models;
using Tour_API.DB;
using Tour_API.Repository.Service;
using Tour_API.Repository.Interface;

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

        // GET: api/Tours/5
        [HttpGet("{id}")]
        public async Task<Tour> GetTourDetails(int id)
        {
      

            return  await _context.GetTourDetails(id);
        }

        // POST: api/Tours
        [HttpPost]
        public async Task<Tour> PostTour(Tour tour)
        {

            return await _context.PostTour(tour);
        }
        // PUT: api/Tours/5
        [HttpPut("{id}")]
        public async Task<Tour> PutTour(int id, Tour tour)
        {
           

            return await _context.PutTour(id, tour);
        }


        // DELETE: api/Tours/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteTour(int id)
        {
     

            return await _context.DeleteTour(id);
        }


    }
}

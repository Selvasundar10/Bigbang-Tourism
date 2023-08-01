using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bigbang_Tourism.Models;
using Booking_API.DB;
using Booking_API.Repository.Interface;

namespace Booking_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Booking_DetailsController : ControllerBase
    {
        private readonly IBooking_Details _context;

        public Booking_DetailsController(IBooking_Details context)
        {
            _context = context;
        }

        // GET: api/Booking_Details
        [HttpGet]
        public async Task<List<Booking_Details>> GetBooking_Details()
        {
        
            return await _context.GetBooking_Details();
        }

        // POST: api/Booking
        [HttpPost]
        public async Task<Booking_Details> PostBooking_Details(Booking_Details booking)
        {

            return await _context.PostBooking_Details(booking);
        }

    }
}

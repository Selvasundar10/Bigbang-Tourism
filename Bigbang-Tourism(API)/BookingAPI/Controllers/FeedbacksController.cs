using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookingAPI.DB;
using ModelsLibrary;
using Tour_API.Repository.Interface;

namespace BookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacksController : ControllerBase
    {
        private readonly IFeedback _context;

        public FeedbacksController(IFeedback context)
        {
            _context = context;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<List<Feedbacks>> GetFeedback()
        {
            return await _context.GetFeedback();
        }



        // POST: api/Tours
        [HttpPost]
        public async Task<Feedbacks> PostFeedback(Feedbacks feedback)
        {

            return await _context.PostFeedback(feedback);
        }
/*        // PUT: api/Tours/5
        [HttpPut("{name}")]
        public async Task<Feedbacks> PutFeedback(string name, Feedbacks feedback)
        {


            return await _context.PutFeedback(name, feedback);
        }


        // DELETE: api/Tours/5
        [HttpDelete("{name}")]
        public async Task<string> DeleteFeedback(int id)
        {

            return await _context.DeleteFeedback(name);
        }*/


    }
}
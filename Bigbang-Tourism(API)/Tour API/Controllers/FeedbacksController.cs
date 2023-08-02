using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bigbang_Tourism.Models;
using Tour_API.DB;

namespace Tour_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacksController : ControllerBase
    {
        private readonly TourContext _context;

        public FeedbacksController(TourContext context)
        {
            _context = context;
        }

        // GET: api/Feedbacks
        [HttpGet]
        public async Task<List<Feedbacks>> GetFeedbacks()
        {
         
            return await _context.GetFeedbacks();
        }

        // GET: api/Feedbacks/5
        [HttpGet("{id}")]
        public async Task<Feedbacks> GetFeedbackDetails(int id)
        {
    

            return await _context.GetfeedbackDetails();
        }

        // PUT: api/Feedbacks/5
        [HttpPut("{id}")]
        public async Task<Feedbacks> PutFeedback(int id, Feedbacks feedback)
        {
           

            return await _context.PutFeedbacks();
        }
   
        // POST: api/Feedbacks
        [HttpPost]
        public async Task<Feedbacks> PostFeedback(Feedbacks feedback)
        {

            return await _context.PostFeedbacks();
        }

        // DELETE: api/Feedbacks/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteFeedback(int id)
        {
           

            return await _context.DeleteFeedbacks();
        }

    }
}

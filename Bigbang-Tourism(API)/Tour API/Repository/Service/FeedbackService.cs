using Bigbang_Tourism.Models;
using Microsoft.EntityFrameworkCore;
using Tour_API.DB;
using Tour_API.Repository.Interface;

namespace Tour_API.Repository.Service
{
    public class FeedbackService : IFeedback
    {
        private readonly TourContext _context;

        public FeedbackService(TourContext context)
        {
            _context = context;
        }

        public async Task<List<Feedbacks>> GetFeedbacks()
        {
            return await _context.Feedbacks.ToListAsync();
        }

        public async Task<Feedbacks> GetFeedbackDetails(int id)
        {
            var doc = await _context.Feedbacks.FirstOrDefaultAsync(x => x.Feedback_Id == id);
            return doc;
        }

        public async Task<Feedbacks> PostFeedbacks(Feedbacks feedback)
        {
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return feedback;
        }

        public async Task<Feedbacks> PutFeedbacks(int id, Feedbacks feedback)
        {
            var _feedback = await _context.Feedbacks.FirstOrDefaultAsync(x => x.Feedback_Id == id);
            if (_feedback == null)
            {
                return null;
            }

            _feedback.Rating = feedback.Rating;
            _feedback.FeedbackMessage = feedback.FeedbackMessage;
     

            _context.Entry(_feedback).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _feedback;
        }

        public async Task<string> DeleteFeedbacks(int id)
        {
            var doc = await _context.Feedbacks.FirstOrDefaultAsync(x => x.Feedback_Id == id);
            if (doc == null)
            {
                return null;
            }
            _context.Feedbacks.Remove(doc);
            await _context.SaveChangesAsync();
            return "Feedback Deleted Successfully";
        }
    }
}
}

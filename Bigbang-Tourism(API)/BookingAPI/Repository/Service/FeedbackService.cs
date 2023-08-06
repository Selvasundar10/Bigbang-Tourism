using BookingAPI.DB;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using Tour_API.Repository.Interface;

namespace Tour_API.Repository.Service
{
    public class FeedbackService : IFeedback
    {
        private readonly BookingContext _context;

        public FeedbackService(BookingContext context)
        {
            _context = context;
        }

        public async Task<List<Feedbacks>> GetFeedback()
        {
            return await _context.Feedbacks.ToListAsync();
        }


        public async Task<Feedbacks> PostFeedback(Feedbacks feedback)
        {
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return feedback;
        }

  /*      public async Task<Feedbacks> PutFeedback(int id, Feedbacks feedback)
        {
            var _feedback = await _context.Feedbacks.FirstOrDefaultAsync(x => x.TravelerId == id);
            if (_feedback == null)
            {
                return null;
            }

            _feedback.FeedbackMessage = feedback.FeedbackMessage;

            _context.Entry(_feedback).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _feedback;
        }
 
        public async Task<string> DeleteFeedback(int id)
        {
            var doc = await _context.Feedbacks.FirstOrDefaultAsync(x => x.TravelerId == id);
            if (doc == null)
            {
                return null;
            }
            _context.Feedbacks.Remove(doc);
            await _context.SaveChangesAsync();
            return "Feedback Deleted Successfully";
        }*/
   

    }

}

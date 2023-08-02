using Bigbang_Tourism.Models;

namespace Tour_API.Repository.Interface
{
    public interface IFeedback
    {
        public Task<List<Feedbacks>> GetFeedback();
        public Task<Feedbacks> GetFeedbackDetails(int id);
        public Task<Feedbacks> PutFeedbacks(int id, Feedbacks feedback);
        public Task<Feedbacks> PostFeedbacks(Feedbacks feedback);
        public Task<string> DeleteFeedbacks (int id);


    }
}

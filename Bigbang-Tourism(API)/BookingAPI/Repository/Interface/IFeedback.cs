using ModelsLibrary;

namespace Tour_API.Repository.Interface
{
    public interface IFeedback
    {
        public Task<List<Feedbacks>> GetFeedback();
        public Task<Feedbacks> PostFeedback(Feedbacks feedback);
 /*       public Task<Feedbacks> PutFeedback(int id, Feedbacks feedback);

        public Task<string> DeleteFeedback(int id);*/


    }
}


using ModelsLibrary;

namespace UserAPI.Repository.Interface
{
    public interface IUserService
    {
        ICollection<User> GetAll();
        User Get(string username);
        User Add(User user);
        User Update(User user);
        User Delete(string userId);

    }
}

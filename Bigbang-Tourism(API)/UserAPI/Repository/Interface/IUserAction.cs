using UserAPI.DTO;

namespace UserAPI.Repository.Interface
{
    public interface IUserAction
    {
        UserDTO Login(UserDTO userDTO);
        UserDTO Register(UserRegisterDTO userDTO);
    }
}

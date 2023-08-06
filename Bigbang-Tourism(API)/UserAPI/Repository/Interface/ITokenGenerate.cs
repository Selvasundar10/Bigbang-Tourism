using UserAPI.DTO;

namespace UserAPI.Interface
{
    public interface ITokenGenerate
    {
        public string GenerateToken(UserDTO user);
    }
}


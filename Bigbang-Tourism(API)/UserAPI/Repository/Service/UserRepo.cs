using Microsoft.IdentityModel.Tokens;
using ModelsLibrary;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserAPI.DB;
using UserAPI.DTO;
using UserAPI.Repository.Interface;

namespace UserAPI.Repository
{
    public class UserRepo : IUserService
    {
        private readonly UserContext _context;

        /// <summary>
        /// This method is used to inject the dependencies
        /// </summary>
        /// <param name="userContext"></param>
        public UserRepo(UserContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method adds a user to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>User</returns>
        public User Add(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }

        /// <summary>
        /// This method deletes a user from the database
        /// </summary>
        /// <param name="username"></param>
        /// <returns>User</returns>
        public User Delete(string userId)
        {
            var user = _context.User.SingleOrDefault(u => u.User_Id == userId);
            if (user != null)
            {
                _context.User.Remove(user);
                _context.SaveChanges();
            }
            return user;
        }

        /// <summary>
        /// This method gets a user from the database
        /// </summary>
        /// <param name="username"></param>
        /// <returns>User</returns>
        public User Get(string userId)
        {
            return _context.User.SingleOrDefault(u => u.User_Id == userId);
        }

        /// <summary>
        /// This method gets all the users from the database
        /// </summary>
        /// <returns>List of User</returns>
        public ICollection<User> GetAll()
        {
            return _context.User.ToList();
        }

        /// <summary>
        /// This method updates a user in the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>User</returns>
        public User Update(User user)
        {
            var userToUpdate = _context.User.SingleOrDefault(u => u.User_Id == user.User_Id);
            if (userToUpdate != null)
            {
                userToUpdate.User_Name = user.User_Name;
                userToUpdate.Email = user.Email;
                userToUpdate.Role = user.Role;
                _context.SaveChanges();
            }
            return userToUpdate;
        }
    }
}

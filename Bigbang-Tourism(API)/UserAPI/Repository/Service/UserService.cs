using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using UserAPI.DTO;
using UserAPI.Interface;
using UserAPI.Repository.Interface;

namespace UserAPI.Repository.Service
{
    public class UserService : IUserAction
    {
        private readonly IUserService _userrepo;
        private readonly ITokenGenerate _tokenService;

        /// <summary>
        /// This method is used to inject the dependencies
        /// </summary>
        /// <param name="userrepo"></param>
        /// <param name="tokenService"></param>
        public UserService(IUserService userrepo, ITokenGenerate tokenService)
        {
            _userrepo = userrepo;
            _tokenService = tokenService;
        }

        /// <summary>
        /// This method is used to Login a  user
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns>UserDTO </returns>
        public UserDTO Login(UserDTO userDTO)
        {
            UserDTO user = null;
            var userData = _userrepo.Get(userDTO.User_Id);
            if (userData != null)
            {
                var hmac = new HMACSHA512(userData.HashKey);
                var userPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));
                for (int i = 0; i < userPass.Length; i++)
                {
                    if (userPass[i] != userData.Password[i])
                        return null;
                }
                user = new UserDTO();
                user.User_Id = userData.User_Id;
                user.Role = userData.Role;
                user.Token = _tokenService.GenerateToken(user);
            }
            return user;
        }


        /// <summary>
        /// This method is used to register a new user
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns>UserDTO</returns>
        public UserDTO Register(UserRegisterDTO userDTO)
        {
            var existingUser = _userrepo.Get(userDTO.User_Id);
            if (existingUser != null)
                return null;
            UserDTO user = null;
            var hmac = new HMACSHA512();
            userDTO.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.PasswordClear));
            userDTO.HashKey = hmac.Key;
            var resultUser = _userrepo.Add(userDTO);
            if (resultUser != null)
            {
                user = new UserDTO();
                user.User_Id = resultUser.User_Id;
                user.Role = resultUser.Role;
                user.Token = _tokenService.GenerateToken(user);
            }
            return user;
        }

    }
}


using Microsoft.AspNetCore.Mvc;

using UserAPI.DTO;
using UserAPI.Repository.Interface;
using ModelsLibrary;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace UserAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserAction _userAction;
        public UsersController(IUserAction userAction)
        {
            _userAction = userAction;
        }

        [HttpPost("Login")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<UserDTO> Login(UserDTO userDTO)
        {
            try
            {
                var user = _userAction.Login(userDTO);
                if (user == null)
                    return NotFound(new Error { errorNumber = 404, errorMessage = "Username or password is incorrect" });
                return Ok(user);
            }
            catch (SqlException se)
            {
                Debug.WriteLine(se.StackTrace);
                return BadRequest(new Error { errorNumber = 0, errorMessage = "Server is not working properly " });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                return BadRequest(new Error { errorNumber = 0, errorMessage = "Something Went Wrong" });
            }
        }




        [HttpPost("Register")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<UserDTO> Register(UserRegisterDTO userDTO)
        {
            try
            {
                var user = _userAction.Register(userDTO);
                if (user == null)
                    return BadRequest(new Error { errorNumber = 400, errorMessage = "Username is already taken" });
                return Ok(user);
            }
            catch (SqlException se)
            {
                Debug.WriteLine(se.StackTrace);
                return BadRequest(new Error { errorNumber = 400, errorMessage = "Server is not working properly " });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                return BadRequest(new Error { errorNumber = 400, errorMessage = "Something Went Wrong" });
            }
        }


    }
}
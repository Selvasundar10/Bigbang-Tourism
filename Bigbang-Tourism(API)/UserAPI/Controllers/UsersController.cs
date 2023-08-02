    //using System;
    //using System.Collections.Generic;
    //using System.Linq;
    //using System.Threading.Tasks;
    //using Microsoft.AspNetCore.Http;
    //using Microsoft.AspNetCore.Mvc;
    //using Microsoft.EntityFrameworkCore;
    //using Bigbang_Tourism.Models;
    //using UserAPI.DB;
    //using Bigbang_Tourism.DTOs;

    //namespace UserAPI.Controllers
    //{
    //    [Route("api/[controller]")]
    //    [ApiController]
    //    public class UsersController : ControllerBase
    //    {
    //        private readonly UserContext _context;

    //        public UsersController(UserContext context)
    //        {
    //            _context = context;
    //        }

    //        // POST: api/Users
    //        [HttpPost]
    //    public ActionResult<UserDTO> Register([FromBody] UserDTO userDTO)
    //        {
    //            if (!ModelState.IsValid)
    //            {
    //                return BadRequest(ModelState);
    //            }

    //            var user = _context.Register(userDTO);

    //            if (user == null)
    //            {
    //                return BadRequest("Unable to register.");
    //            }

    //            return Created("Home", user);
    //        }
    //        [HttpPost("Login")]
    //        public ActionResult<UserDTO> Login([FromBody] UserDTO userDTO)
    //        {
    //            if (!ModelState.IsValid)
    //            {
    //                return BadRequest(ModelState);
    //            }
    //            var user = _context.Login(userDTO.User_Name, userDTO.Password);

    //            if (user == null)
    //            {
    //                return BadRequest("Invalid username or password.");
    //            }

    //        }


    //    }
    //}

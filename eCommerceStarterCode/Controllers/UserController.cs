using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/users/")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Left out Authorize
        [HttpGet("user")]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users;
            return Ok(users);
        }

        //Get current user
        [HttpGet("{userId}")]
        public IActionResult GetCurrentUser(string userId)
        {
            var currentUser = _context.Users.Where(u => u.Id == userId).SingleOrDefault();
            if (currentUser == null)
            {
                return NotFound();
            }
            return Ok(currentUser);
        }

        [HttpPut("complete/{userId}")]
        public IActionResult CompleteUserDetails(string userId, [FromBody] User userDetails)
        {
            var user = _context.Users.Where(u => u.Id == userId).SingleOrDefault();
            user.StreetAddress = userDetails.StreetAddress;
            user.City = userDetails.City;
            user.State = userDetails.State;

            _context.Users.Update(user);
            _context.SaveChanges();
            return StatusCode(201, user);
        }

        [HttpPut("edit/{userId}")]
        public IActionResult EditUserDetails(string userId, [FromBody] User userDetails)
        {
            var user = _context.Users.Where(u => u.Id == userId).SingleOrDefault();

            user.UserName = userDetails.UserName;
            user.FirstName = userDetails.FirstName;
            user.LastName = userDetails.LastName;
            user.Email = userDetails.Email;
            user.StreetAddress = userDetails.StreetAddress;
            user.City = userDetails.City;
            user.State = userDetails.State;


            _context.Users.Update(user);
            _context.SaveChanges();
            return StatusCode(201, user);
        }


    }
}

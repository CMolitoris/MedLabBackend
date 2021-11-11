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
    [Route("api/profile/")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProfileController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Left out Authorize
        [HttpGet("all")]
        public IActionResult GetAllProfiles()
        {
            var profiles = _context.Profiles;
            return Ok(profiles);
        }

        [HttpPost]
        public IActionResult PostProfile([FromBody] Profile profile)
        {
            Profile newProfile = profile;
            _context.Profiles.Add(newProfile);
            _context.SaveChanges();

            

            return StatusCode(201, newProfile);
        }

        [HttpPut("edit/{userId}")]
        public IActionResult EditProfileDetails(string userId, [FromBody] Profile profileDetails)
        {
            var profile = _context.Profiles.Where(u => u.User.Id == userId).SingleOrDefault(); 

            profile.Age = profileDetails.Age;
            profile.Height = profileDetails.Height;
            profile.Weight = profileDetails.Weight;
            profile.Gender = profileDetails.Gender;


            _context.Profiles.Update(profile);
            _context.SaveChanges();
            return StatusCode(201, profile);
        }


    }
}

using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/BMPList/")]
    [ApiController]
    public class BMPListController : ControllerBase
    {
        private ApplicationDbContext _context;

        public BMPListController(ApplicationDbContext context)
        {
            _context = context;
        }

        //-- Get all CBCLists --//
        [HttpGet("all/")]
        public IActionResult GetAllBMPLists()
        {
            var BMPLists = _context.BMPLists;
            return Ok(BMPLists);
        }

        [HttpGet("all/{userId}")]
        public IActionResult GetAllBMPListsUser(string userId)
        {
            var UserBMP = _context.BMPLists.Where(uc => uc.UserId == userId).Include(uc => uc.BMP).ToList();
            return Ok(UserBMP);
        }

        [HttpPost("create/")]
        public IActionResult PostBMPList([FromBody] BMPList bmpList)
        {
            _context.BMPLists.Add(bmpList);
            _context.SaveChanges();
            return StatusCode(201, bmpList);
        }

        [HttpDelete("delete/{userId}/{testId}")]
        public IActionResult DeleteBMPList(string userId, int testId)
        {
            var BMPList = _context.BMPLists.Where(cl => cl.BMPId == testId && cl.UserId == userId).SingleOrDefault();
            _context.Remove(BMPList);
            _context.SaveChanges();
            return Ok(BMPList);
        }

    }
}

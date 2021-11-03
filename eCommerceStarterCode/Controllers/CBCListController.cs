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
    [Route("api/CBCList/")]
    [ApiController]
    public class CBCListController: ControllerBase
    {
        private ApplicationDbContext _context;

        public CBCListController(ApplicationDbContext context)
        {
            _context = context;
        }

        //-- Get all CBCLists --//
        [HttpGet("all/")]
        public IActionResult GetAllCBCLists()
        {
            var CBCLists = _context.CBCLists;
            return Ok(CBCLists);
        }

        [HttpGet("all/{userId}")]
        public IActionResult GetAllCBCListsUser(string userId)
        {
            var UserCBC = _context.CBCLists.Where(uc => uc.UserId == userId).Include(uc => uc.CBC).ToList();
            return Ok(UserCBC);
        }

        [HttpPost("create/")]
        public IActionResult PostCBCList([FromBody]CBCList cbcList)
        {
            _context.CBCLists.Add(cbcList);
            _context.SaveChanges();
            return StatusCode(201, cbcList);
        }

        [HttpDelete("delete/{userId}/{testId}")]
        public IActionResult DeleteCBCList(string userId, int testId)
        {
            var CBCList = _context.CBCLists.Where(cl => cl.CBCId == testId && cl.UserId == userId).SingleOrDefault();
            _context.Remove(CBCList);
            _context.SaveChanges();
            return Ok(CBCList);
        }

    }
}

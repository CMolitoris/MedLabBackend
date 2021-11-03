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
    [Route("api/ConditionList/")]
    [ApiController]
    public class ConditionListController : ControllerBase
    {
        private ApplicationDbContext _context;

        public ConditionListController(ApplicationDbContext context)
        {
            _context = context;
        }

        //-- Get all CBCLists --//
        [HttpGet("all/")]
        public IActionResult GetAllConditionLists()
        {
            var ConditionLists = _context.ConditionLists;
            return Ok(ConditionLists);
        }

        [HttpGet("all/{userId}/")]
        public IActionResult GetAllConditionListsUser(string userId)
        {
            var UserCBC = _context.ConditionLists.Where(uc => uc.UserId == userId).Include(uc => uc.Condition).ToList();
            return Ok(UserCBC);
        }

        [HttpPost("create/")]
        public IActionResult PostConditionList([FromBody] ConditionList conditionList)
        {
            _context.ConditionLists.Add(conditionList);
            _context.SaveChanges();
            return StatusCode(201, conditionList);
        }

        [HttpDelete("delete/{userId}/{testId}")]
        public IActionResult DeleteConditionList(string userId, int testId)
        {
            var ConditionList = _context.ConditionLists.Where(cl => cl.ConditionId == testId && cl.UserId == userId).SingleOrDefault();
            _context.Remove(ConditionList);
            _context.SaveChanges();
            return Ok(ConditionList);
        }

    }
}

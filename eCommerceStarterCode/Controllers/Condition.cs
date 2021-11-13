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
    [Route("api/Condition/")]
    [ApiController]
    public class ConditionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ConditionController(ApplicationDbContext context)
        {
            _context = context;
        }

        //-- GET api/Condition/ --//
        [HttpGet]
        public IActionResult GetAllConditions()
        {
            var conditions = _context.Conditions;
            return Ok(conditions);
        }

        [HttpGet("{conditionId}")]
        public IActionResult GetCondition(int conditionId)
        {
            var condition = _context.Conditions.Where(c => c.Id == conditionId).SingleOrDefault();
            return Ok(condition);
        }

        //-- POST api/Condition/ --//
        [HttpPost]
        public IActionResult PostCondition([FromBody] Condition newCondition)
        {
            Condition conditionToAdd = newCondition;
            _context.Conditions.Add(conditionToAdd);
            _context.SaveChanges();

            return StatusCode(201, conditionToAdd);
        }


        //-- PUT api/Condition/edit/{conditionId} --//
        [HttpPut("edit/{conditionId}")]
        public IActionResult UpdateCondition(int conditionId, [FromBody] Condition value)
        {
            var condition = _context.Conditions.Where(o => o.Id == conditionId).SingleOrDefault();
            if (condition == null)
            {
                return NotFound("Requested order not found");
            }

            return StatusCode(201, condition);
        }

        //-- DELETE api/Condition/delete/{conditionId}/ --//
        [HttpDelete("delete/{conditionId}")]
        public IActionResult DeleteCondition(int conditionId)
        {
            Condition condition = _context.Conditions.Where(c => c.Id == conditionId).SingleOrDefault();
            _context.Conditions.Remove(condition);
            _context.SaveChanges();
            return Ok(condition);
        }

    }
}

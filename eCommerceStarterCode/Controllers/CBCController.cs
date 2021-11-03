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
    [Route("api/CBC/")]
    [ApiController]
    public class CBCController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CBCController(ApplicationDbContext context)
        {
            _context = context;
        }

        //-- GET api/CBC/ --//
        [HttpGet]
        public IActionResult GetAllTests()
        {
            var tests = _context.CBCs;
            return Ok(tests);
        }

        //-- POST api/CBC/{userId} --//
        [HttpPost("{userId}")]
        public IActionResult PostTest(string userId, [FromBody] CBC newCBC)
        {
            CBC cbcToAdd = newCBC;
            _context.CBCs.Add(cbcToAdd);
            _context.SaveChanges();

            _context.CBCLists.Add(new CBCList { UserId = userId, CBCId = cbcToAdd.Id });
            _context.SaveChanges();

            return StatusCode(201, cbcToAdd);
        }

        //-- GET api/CBC/{testId} --//
        [HttpGet("{testId}/")]
        public IActionResult GetIdOrders(int testId)
        {
            var selectedTest = _context.CBCs.Where(c => c.Id == testId).SingleOrDefault();
            return Ok(selectedTest);
        }

        //-- PUT api/CBC/edit/{testId} --//
        [HttpPut("edit/{testId}/")]
        public IActionResult UpdateCBC(int testId, [FromBody] CBC value)
        {
            var test = _context.CBCs.Where(o => o.Id == testId).SingleOrDefault();
            if (test == null)
            {
                return NotFound("Requested order not found");
            }

            test.Rbc = value.Rbc;
            test.Hb = value.Hb;
            test.Hct = value.Hct;
            test.MCV = value.MCV;
            test.MCH = value.MCH;
            test.MCHC = value.MCHC;
            test.RDW = value.RDW;
            test.WBC = value.WBC;
            test.Neu = value.Neu;
            test.Lym = value.Lym;
            test.Mon = value.Mon;
            test.Eos = value.Eos;
            test.Bas = value.Bas;
            test.Plt = value.Plt;


            _context.CBCs.Update(test);
            _context.SaveChanges();
            return StatusCode(201, test);
        }

        //-- DELETE api/CBC/delete/{testId}/ --//
        [HttpDelete("delete/{testId}/")]
        public IActionResult DeleteCar(int testId)
        {
            CBC test = _context.CBCs.Where(c => c.Id == testId).SingleOrDefault();
            _context.CBCs.Remove(test);
            _context.SaveChanges();
            return Ok(test);
        }

    }
}

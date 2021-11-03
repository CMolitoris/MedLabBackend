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
    [Route("api/BMP/")]
    [ApiController]
    public class BMPController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BMPController(ApplicationDbContext context)
        {
            _context = context;
        }

        //-- GET api/BMP/ --//
        [HttpGet]
        public IActionResult GetAllTests()
        {
            var tests = _context.BMPs;
            return Ok(tests);
        }

        //-- POST api/BMP/ --//
        [HttpPost("{userId}")]
        public IActionResult PostTest(string userId,[FromBody] BMP newBMP)
        {
            BMP bmpToAdd = newBMP;
            _context.BMPs.Add(bmpToAdd);
            _context.SaveChanges();

            _context.BMPLists.Add(new BMPList{UserId=userId,BMPId=bmpToAdd.Id });
            _context.SaveChanges();
            return StatusCode(201, bmpToAdd);
        }

        //-- GET api/BMP/{testId} --//
        [HttpGet("{testId}/")]
        public IActionResult GetIdOrders(int testId)
        {
            var selectedCar = _context.BMPs.Where(c => c.Id == testId).SingleOrDefault();
            return Ok(selectedCar);
        }

        //-- PUT api/BMP/edit/{carId} --//
        [HttpPut("edit/{testId}/")]
        public IActionResult UpdateCar(int testId, [FromBody] BMP value)
        {
            var test = _context.BMPs.Where(o => o.Id == testId).SingleOrDefault();
            if (test == null)
            {
                return NotFound("Requested order not found");
            }

            test.Sodium = value.Sodium;
            test.Potassium = value.Potassium;
            test.Glucose = value.Glucose;
            test.Calcium = value.Calcium;
            test.Chloride = value.Chloride;
            test.Bicarbonate = value.Bicarbonate;
            test.Creatinine = value.Creatinine;
            test.BUN = value.BUN;


            _context.BMPs.Update(test);
            _context.SaveChanges();
            return StatusCode(201, test);
        }

        //-- DELETE api/BMP/delete/{testId}/ --//
        [HttpDelete("delete/{testId}/")]
        public IActionResult DeleteCar(int testId)
        {
            BMP test = _context.BMPs.Where(c => c.Id == testId).SingleOrDefault();
            _context.BMPs.Remove(test);
            _context.SaveChanges();
            return Ok(test);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InsuranceAPI.DB;

namespace InsuranceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Route("insurance")]
    public class InsuranceDetailsController : ControllerBase
    {
        private readonly InsuranceCapstoneProjectContext _context;

        public InsuranceDetailsController(InsuranceCapstoneProjectContext context)
        {
            _context = context;
        }

        // GET: api/InsuranceDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InsuranceDetail>>> GetInsuranceDetails()
        {
          if (_context.InsuranceDetails == null)
          {
              return NotFound();
          }
            return await _context.InsuranceDetails.ToListAsync();
        }

        // GET: api/InsuranceDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InsuranceDetail>> GetInsuranceDetail(int id)
        {
          if (_context.InsuranceDetails == null)
          {
              return NotFound();
          }
            var insuranceDetail = await _context.InsuranceDetails.FindAsync(id);

            if (insuranceDetail == null)
            {
                return NotFound();
            }

            return insuranceDetail;
        }

        // PUT: api/InsuranceDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInsuranceDetail(int id, InsuranceDetail insuranceDetail)
        {
            if (id != insuranceDetail.InsuranceId)
            {
                return BadRequest();
            }

            _context.Entry(insuranceDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsuranceDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/InsuranceDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InsuranceDetail>> PostInsuranceDetail(InsuranceDetail insuranceDetail)
        {
          if (_context.InsuranceDetails == null)
          {
              return Problem("Entity set 'InsuranceCapstoneProjectContext.InsuranceDetails'  is null.");
          }
            _context.InsuranceDetails.Add(insuranceDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInsuranceDetail", new { id = insuranceDetail.InsuranceId }, insuranceDetail);
        }

        // DELETE: api/InsuranceDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInsuranceDetail(int id)
        {
            if (_context.InsuranceDetails == null)
            {
                return NotFound();
            }
            var insuranceDetail = await _context.InsuranceDetails.FindAsync(id);
            if (insuranceDetail == null)
            {
                return NotFound();
            }

            _context.InsuranceDetails.Remove(insuranceDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InsuranceDetailExists(int id)
        {
            return (_context.InsuranceDetails?.Any(e => e.InsuranceId == id)).GetValueOrDefault();
        }

        //[HttpGet("SearchInsuranceProducts")]
        //public ActionResult<IEnumerable<InsuranceDetail>> SearchInsuranceProduct(
        //    string productName=null,
        //    string productCategory =null,
        //    decimal? minPrice = null,
        //    decimal? maxPrice = null,
        //    string productBrand = null,
        //    int? productAgeRequirement = null)
        //{


        //    var result = _context.SearchInsuranceProduct(
        //        productName,
        //        productCategory,
        //        minPrice,
        //        maxPrice,
        //        productBrand,
        //        productAgeRequirement);

        //    return Ok(result);
        //}
        [HttpGet]
        [Route("search/by-name/{name}")]
        public IActionResult SearchByName(string name)
        {
           
            var result = _context.SearchInsuranceByName(name);
            return Ok(result);
        }

        [HttpGet]
        [Route("search/by-category/{category}")]
        public IActionResult SearchByCategory(string category)
        {

            var result = _context.SearchInsuranceByCategory(category);
            return Ok(result);
        }

        [HttpGet]
        [Route("search/by-price/{p1}-{p2}")]
        public IActionResult SearchByPriceRange(double p1, double p2)
        {

            var result = _context.SearchInsuranceByPriceRange(p1,p2);
            return Ok(result);
        }
        [HttpGet]
        [Route("search/by-maxp/{p1}")]
        public IActionResult SearchByMaxPrice(double p1)
        {

            var result = _context.SearchInsuranceByMaxPrice(p1);
            return Ok(result);
        }
        [HttpGet]
        [Route("search/by-minp/{p2}")]
        public IActionResult SearchByMinPrice(double p2)
        {

            var result = _context.SearchInsuranceByMinPrice(p2);
            return Ok(result);
        }
        [HttpGet]
        [Route("search/by-age/{a1}-{a2}")]
        public IActionResult SearchByAge(int a1, int a2)
        {

            var result = _context.SearchInsuranceByAge(a1, a2);
            return Ok(result);
        }
        [HttpPost]
        [Route("admin/add")]
        public IActionResult AddInsurance(string insuranceBrand, string insuranceCategory, string insuranceDescription, decimal insurancePrice, int insuranceAgeRequirement)
        {
            try
            {
                _context.AddInsuranceDetail(insuranceBrand, insuranceCategory, insuranceDescription, insurancePrice, insuranceAgeRequirement);
                return Ok("Insurance detail added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while adding insurance detail: {ex.Message}");
            }
        }
        [HttpDelete]
        [Route("admin/delete/{id}")]
        public IActionResult DeleteInsurance(int id)
        {
            try
            {
                _context.DeleteInsuranceDetail(id);
                return Ok("Insurance detail deleted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while deleting insurance detail: {ex.Message}");
            }
        }


    }
}

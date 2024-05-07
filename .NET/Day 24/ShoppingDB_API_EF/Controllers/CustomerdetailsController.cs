using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingDB_API_EF;

namespace ShoppingDB_API_EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerdetailsController : ControllerBase
    {
        private readonly ShoppingDbApiContext _context = new ShoppingDbApiContext();

        //public CustomerdetailsController(ShoppingDbApiContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Customerdetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customerdetail>>> GetCustomerdetails()
        {
          if (_context.Customerdetails == null)
          {
              return NotFound();
          }
            return await _context.Customerdetails.ToListAsync();
        }

        // GET: api/Customerdetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customerdetail>> GetCustomerdetail(int id)
        {
          if (_context.Customerdetails == null)
          {
              return NotFound();
          }
            var customerdetail = await _context.Customerdetails.FindAsync(id);

            if (customerdetail == null)
            {
                return NotFound();
            }

            return customerdetail;
        }

        // PUT: api/Customerdetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerdetail(int id, Customerdetail customerdetail)
        {
            if (id != customerdetail.CId)
            {
                return BadRequest();
            }

            _context.Entry(customerdetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerdetailExists(id))
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

        // POST: api/Customerdetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customerdetail>> PostCustomerdetail(Customerdetail customerdetail)
        {
          if (_context.Customerdetails == null)
          {
              return Problem("Entity set 'ShoppingDbApiContext.Customerdetails'  is null.");
          }
            _context.Customerdetails.Add(customerdetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CustomerdetailExists(customerdetail.CId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCustomerdetail", new { id = customerdetail.CId }, customerdetail);
        }

        // DELETE: api/Customerdetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerdetail(int id)
        {
            if (_context.Customerdetails == null)
            {
                return NotFound();
            }
            var customerdetail = await _context.Customerdetails.FindAsync(id);
            if (customerdetail == null)
            {
                return NotFound();
            }

            _context.Customerdetails.Remove(customerdetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerdetailExists(int id)
        {
            return (_context.Customerdetails?.Any(e => e.CId == id)).GetValueOrDefault();
        }
    }
}

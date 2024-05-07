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
    public class OrderdetailsController : ControllerBase
    {
        private readonly ShoppingDbApiContext _context = new ShoppingDbApiContext();

        //public OrderdetailsController(ShoppingDbApiContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Orderdetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orderdetail>>> GetOrderdetails()
        {
          if (_context.Orderdetails == null)
          {
              return NotFound();
          }
            return await _context.Orderdetails.ToListAsync();
        }

        // GET: api/Orderdetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Orderdetail>> GetOrderdetail(int id)
        {
          if (_context.Orderdetails == null)
          {
              return NotFound();
          }
            var orderdetail = await _context.Orderdetails.FindAsync(id);

            if (orderdetail == null)
            {
                return NotFound();
            }

            return orderdetail;
        }

        // PUT: api/Orderdetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderdetail(int id, Orderdetail orderdetail)
        {
            if (id != orderdetail.OId)
            {
                return BadRequest();
            }

            _context.Entry(orderdetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderdetailExists(id))
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

        // POST: api/Orderdetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Orderdetail>> PostOrderdetail(Orderdetail orderdetail)
        {
          if (_context.Orderdetails == null)
          {
              return Problem("Entity set 'ShoppingDbApiContext.Orderdetails'  is null.");
          }
            _context.Orderdetails.Add(orderdetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrderdetailExists(orderdetail.OId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrderdetail", new { id = orderdetail.OId }, orderdetail);
        }

        // DELETE: api/Orderdetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderdetail(int id)
        {
            if (_context.Orderdetails == null)
            {
                return NotFound();
            }
            var orderdetail = await _context.Orderdetails.FindAsync(id);
            if (orderdetail == null)
            {
                return NotFound();
            }

            _context.Orderdetails.Remove(orderdetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderdetailExists(int id)
        {
            return (_context.Orderdetails?.Any(e => e.OId == id)).GetValueOrDefault();
        }
    }
}

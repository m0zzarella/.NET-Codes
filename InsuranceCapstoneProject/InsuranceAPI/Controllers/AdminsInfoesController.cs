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
    public class AdminsInfoesController : ControllerBase
    {
        private readonly InsuranceCapstoneProjectContext _context;

        public AdminsInfoesController(InsuranceCapstoneProjectContext context)
        {
            _context = context;
        }

        // GET: api/AdminsInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminsInfo>>> GetAdminsInfos()
        {
          if (_context.AdminsInfos == null)
          {
              return NotFound();
          }
            return await _context.AdminsInfos.ToListAsync();
        }

        // GET: api/AdminsInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdminsInfo>> GetAdminsInfo(int id)
        {
          if (_context.AdminsInfos == null)
          {
              return NotFound();
          }
            var adminsInfo = await _context.AdminsInfos.FindAsync(id);

            if (adminsInfo == null)
            {
                return NotFound();
            }

            return adminsInfo;
        }

        // PUT: api/AdminsInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminsInfo(int id, AdminsInfo adminsInfo)
        {
            if (id != adminsInfo.AdminId)
            {
                return BadRequest();
            }

            _context.Entry(adminsInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminsInfoExists(id))
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

        // POST: api/AdminsInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AdminsInfo>> PostAdminsInfo(AdminsInfo adminsInfo)
        {
          if (_context.AdminsInfos == null)
          {
              return Problem("Entity set 'InsuranceCapstoneProjectContext.AdminsInfos'  is null.");
          }
            _context.AdminsInfos.Add(adminsInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdminsInfo", new { id = adminsInfo.AdminId }, adminsInfo);
        }

        // DELETE: api/AdminsInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminsInfo(int id)
        {
            if (_context.AdminsInfos == null)
            {
                return NotFound();
            }
            var adminsInfo = await _context.AdminsInfos.FindAsync(id);
            if (adminsInfo == null)
            {
                return NotFound();
            }

            _context.AdminsInfos.Remove(adminsInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminsInfoExists(int id)
        {
            return (_context.AdminsInfos?.Any(e => e.AdminId == id)).GetValueOrDefault();
        }
    }
}

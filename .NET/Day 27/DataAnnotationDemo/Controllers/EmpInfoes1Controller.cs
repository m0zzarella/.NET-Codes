﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAnnotationDemo;

namespace DataAnnotationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpInfoes1Controller : ControllerBase
    {
        private readonly EmpDbDataAnnotationContext _context;

        public EmpInfoes1Controller(EmpDbDataAnnotationContext context)
        {
            _context = context;
        }

        // GET: api/EmpInfoes1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpInfo>>> GetEmpInfos()
        {
          if (_context.EmpInfos == null)
          {
              return NotFound();
          }
            return await _context.EmpInfos.ToListAsync();
        }

        // GET: api/EmpInfoes1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpInfo>> GetEmpInfo(int id)
        {
          if (_context.EmpInfos == null)
          {
              return NotFound();
          }
            var empInfo = await _context.EmpInfos.FindAsync(id);

            if (empInfo == null)
            {
                return NotFound();
            }

            return empInfo;
        }

        // PUT: api/EmpInfoes1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpInfo(int id, EmpInfo empInfo)
        {
            if (id != empInfo.EmpNo)
            {
                return BadRequest();
            }

            _context.Entry(empInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpInfoExists(id))
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

        // POST: api/EmpInfoes1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpInfo>> PostEmpInfo(EmpInfo empInfo)
        {
          if (_context.EmpInfos == null)
          {
              return Problem("Entity set 'EmpDbDataAnnotationContext.EmpInfos'  is null.");
          }
            _context.EmpInfos.Add(empInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmpInfoExists(empInfo.EmpNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmpInfo", new { id = empInfo.EmpNo }, empInfo);
        }

        // DELETE: api/EmpInfoes1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpInfo(int id)
        {
            if (_context.EmpInfos == null)
            {
                return NotFound();
            }
            var empInfo = await _context.EmpInfos.FindAsync(id);
            if (empInfo == null)
            {
                return NotFound();
            }

            _context.EmpInfos.Remove(empInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpInfoExists(int id)
        {
            return (_context.EmpInfos?.Any(e => e.EmpNo == id)).GetValueOrDefault();
        }
    }
}

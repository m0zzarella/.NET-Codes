using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CORS_BankingAPI;

namespace CORS_BankingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsInfoesController : ControllerBase
    {
        private readonly BankingDbEfContext _context = new BankingDbEfContext();

        //public AccountsInfoesController(BankingDbEfContext context)
        //{
        //    _context = context;
        //}

        // GET: api/AccountsInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountsInfo>>> GetAccountsInfos()
        {
          if (_context.AccountsInfos == null)
          {
              return NotFound();
          }
            return await _context.AccountsInfos.ToListAsync();
        }

        // GET: api/AccountsInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountsInfo>> GetAccountsInfo(int id)
        {
          if (_context.AccountsInfos == null)
          {
              return NotFound();
          }
            var accountsInfo = await _context.AccountsInfos.FindAsync(id);

            if (accountsInfo == null)
            {
                return NotFound();
            }

            return accountsInfo;
        }

        // PUT: api/AccountsInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccountsInfo(int id, AccountsInfo accountsInfo)
        {
            if (id != accountsInfo.AccNo)
            {
                return BadRequest();
            }

            _context.Entry(accountsInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountsInfoExists(id))
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

        // POST: api/AccountsInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AccountsInfo>> PostAccountsInfo(AccountsInfo accountsInfo)
        {
          if (_context.AccountsInfos == null)
          {
              return Problem("Entity set 'BankingDbEfContext.AccountsInfos'  is null.");
          }
            _context.AccountsInfos.Add(accountsInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AccountsInfoExists(accountsInfo.AccNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAccountsInfo", new { id = accountsInfo.AccNo }, accountsInfo);
        }

        // DELETE: api/AccountsInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccountsInfo(int id)
        {
            if (_context.AccountsInfos == null)
            {
                return NotFound();
            }
            var accountsInfo = await _context.AccountsInfos.FindAsync(id);
            if (accountsInfo == null)
            {
                return NotFound();
            }

            _context.AccountsInfos.Remove(accountsInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccountsInfoExists(int id)
        {
            return (_context.AccountsInfos?.Any(e => e.AccNo == id)).GetValueOrDefault();
        }

        [HttpGet("getAllProducts")]
        public IActionResult GetTotalProducts()
        {
            var data = from e in _context.AccountsInfos
                        select e;
            return Ok(data);
        }
    }
}

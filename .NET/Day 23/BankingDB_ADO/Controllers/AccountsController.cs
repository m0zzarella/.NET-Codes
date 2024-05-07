using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingDB_ADO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        Accounts accObj;
        public AccountsController(Accounts accRef)
        {
            accObj = accRef;
        }

        [HttpGet("showallaccounts")]
        public IActionResult getAllAccounts()
        {
            var data = accObj.allAccounts();

            return Ok(data);
        }
        [HttpGet("showaccountsbyaccNo/{accNoNew}")]
        public IActionResult getAccountsbyAccNo(int accNoNew)
        { foreach(var account in accObj.allAccounts())
                { 
                if(account.accNo == accNoNew) 
                    return Ok(account); }
            return BadRequest("No Account Found");
        }
        [HttpGet("showaccountsbyaccName/{accNameNew}")]
        public IActionResult getAccountsbyAccName(string accNameNew)
        {
            foreach (var account in accObj.allAccounts())
            {
                if (account.accName == accNameNew)
                    return Ok(account);
            }
            return BadRequest("No Account Found");
        }
        [HttpGet("totalAccounts")]
        public IActionResult totalAccounts()
        {
            int count = 0;
            foreach (var account in accObj.allAccounts())
            {
                count++;
            }
            return Ok(count);
        }

        [HttpPut("addNewAccount")]
        public IActionResult newAccounts(int uaccNo, string uaccName, string uaccType, int uaccBalance, bool uAccActive, int uAccBranch )
        {
           
            accObj.addNewAccounts(uaccNo, uaccName, uaccType, uaccBalance, uAccActive, uAccBranch);
            
            return Ok("Account Added! ");
        }
        [HttpDelete("deleteAccount")]
        public IActionResult deleteAccount (int accNo)
        {
            accObj.deleteAccounts(accNo);
            return Ok("Account Deleted Succesfully with Account No: " + accNo);
        }
        [HttpPost("updateAccountName")]

        public IActionResult updateName(int accNo, string newAccName)
        {
            accObj.updateName(accNo, newAccName);
            return Ok("Account Updated");
        }

    }
}

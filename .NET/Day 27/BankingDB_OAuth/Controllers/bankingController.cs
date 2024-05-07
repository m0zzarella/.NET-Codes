using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankingDB_OAuth.Controllers
{
    public class bankingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutBanking()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
        [Authorize]
        public IActionResult TransferFunds()
        {
            return View();
        }
        [Authorize]
        public IActionResult DownloadStatement()
        {
            return View();
        }
    }
}

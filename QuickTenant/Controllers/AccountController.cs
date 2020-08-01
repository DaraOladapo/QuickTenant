using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using QuickTenant.Data;

namespace QuickTenant.Controllers
{
    [Route("profile")]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public AccountController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        [Route("{UserID}")]
        public IActionResult Index(string UserID)
        {
            var Account = dbContext.Accounts.FirstOrDefault(option => option.UserID.ToLower() == UserID.ToLower());
            if (Account != null)
                return View(Account);
            else
                return NotFound();
        }
    }
}

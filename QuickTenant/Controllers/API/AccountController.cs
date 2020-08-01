using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickTenant.Data;
using QuickTenant.Models;

namespace QuickTenant.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public AccountController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        public ActionResult<Account> CreateAccount([FromBody] CreateAccount createAccount)
        {
            if (ModelState.IsValid)
            {
                var AccountToCreate = new Account()
                {
                    CreatedDate = DateTime.Now,
                    EmailAddress = createAccount.EmailAddress,
                    FirstName = createAccount.FirstName,
                    LastName = createAccount.LastName,
                    UserID = createAccount.UserID,
                    ObjectID=Guid.NewGuid.ToString()
                };

                var CreatedAccount = dbContext.Accounts.Add(AccountToCreate).Entity;
                dbContext.SaveChanges();
                return CreatedAccount;
            }
            else
                return BadRequest("Invalid input");
        }
    }
}

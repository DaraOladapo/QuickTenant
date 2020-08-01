using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuickTenant.Models;

namespace QuickTenant.Data
{

    public class ApplicationDbContext : DbContext
    {

        ILogger<ApplicationDbContext> _logger;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ILogger<ApplicationDbContext> logger)
          : base(options)
        {
            _logger = logger;
        }

        public DbSet<Account> Accounts { get; set; }

        // public override void OnModelCreating(ModelBuilder builder)
        // {
        //   base.OnModelCreating(builder);

        // }
    }
}
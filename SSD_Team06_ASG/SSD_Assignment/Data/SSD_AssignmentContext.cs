using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SSD_Assignment.Models;


namespace SSD_Assignment.Data
{
    public class SSD_AssignmentContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public SSD_AssignmentContext (DbContextOptions<SSD_AssignmentContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<SSD_Assignment.Models.Book> Book { get; set; }

        //public DbSet<SSD_Assignment.Models.Review> Review { get; set; }
        public DbSet<SSD_Assignment.Models.AuditRecord> AuditRecords { get; set; }
        public DbSet<SSD_Assignment.Models.Feedback> Feedback { get; set; }
        public DbSet<SSD_Assignment.Models.Payment> Payment { get; set; }
    }
}

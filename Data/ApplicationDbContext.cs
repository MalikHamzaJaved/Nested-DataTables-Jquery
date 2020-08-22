using System;
using System.Collections.Generic;
using System.Text;
using DemoDataGridForSaad.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoDataGridForSaad.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CustomerTB> CustomerTB { get; set; }
    }
}

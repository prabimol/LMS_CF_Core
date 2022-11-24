using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_CF_Core.Models;

namespace LMS_CF_Core.Models
{
    public class LMSDbContext : DbContext
    {
        public LMSDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LMS_CF_Core.Models.Login> Login { get; set; }
    }
}

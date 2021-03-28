using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VarnaTour.Models;

namespace VarnaTour.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VarnaTour.Models.Beach> Beach { get; set; }
        public DbSet<VarnaTour.Models.Site> Site { get; set; }
        public DbSet<VarnaTour.Models.ProjectRole> ProjectRole { get; set; }
    }
}

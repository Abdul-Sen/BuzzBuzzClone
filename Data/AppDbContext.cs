using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Showcase.Models;

namespace Showcase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProjectModel> Project { get; set; }
        public DbSet<AddressModel> Address { get; set; }
        public DbSet<BuilderModel> Builder { get; set; }
        public DbSet<UnitsModel> Units { get; set; }
    }
}

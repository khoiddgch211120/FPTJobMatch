using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FPTJobMatch.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FPTJobMatch.Models.Location> Location { get; set; } = default!;
        public DbSet<FPTJobMatch.Models.JobApplication> JobApplication { get; set; } = default!;
        public DbSet<FPTJobMatch.Models.JobListing> JobListing { get; set; } = default!;
        public IEnumerable<object> Locations { get; internal set; }
    }
}

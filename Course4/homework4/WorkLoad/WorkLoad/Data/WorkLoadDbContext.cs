using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkLoad.Configurations;
using WorkLoad.Entities;

namespace WorkLoad.Data
{
    public class WorkLoadDbContext : DbContext
    {
        public WorkLoadDbContext() { }
        public WorkLoadDbContext(DbContextOptions<WorkLoadDbContext> options) : base(options)
        {

        }
        public DbSet<Freelancer> Freelancer { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Workday> Workday { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FreelancerEntityConfigurations());
            modelBuilder.ApplyConfiguration(new ProjectEntityConfigurations());
            modelBuilder.ApplyConfiguration(new WorkdayEntityConfigurations());

        }
    }
}

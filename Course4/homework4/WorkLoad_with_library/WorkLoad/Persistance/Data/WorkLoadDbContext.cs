
using Microsoft.EntityFrameworkCore;
using Persistance.Entities;
using Persistance.Configurations;

namespace Persistance.Data
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
        public DbSet<AddressFreelancer> AddressFreelancer { get; set; }
        public DbSet<AddressProject> AddressProject { get; set; }
        public DbSet<Customer> Customer { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FreelancerEntityConfigurations());
            modelBuilder.ApplyConfiguration(new ProjectEntityConfigurations());
            modelBuilder.ApplyConfiguration(new WorkdayEntityConfigurations());

        }
    }
}

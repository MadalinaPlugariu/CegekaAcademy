using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Persistance.Entities;

namespace Persistance.Configurations
{
    public class FreelancerEntityConfigurations : IEntityTypeConfiguration<Freelancer>
    {
        public void Configure(EntityTypeBuilder<Freelancer> builder)
        {
            builder.Property(f => f.FreelancerInfo).IsRequired();
            builder.Property(p => p.Price).IsRequired();
        }
    }
}

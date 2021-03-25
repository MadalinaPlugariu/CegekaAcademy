using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;
using Microsoft.EntityFrameworkCore;

namespace WorkLoad.Configurations
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

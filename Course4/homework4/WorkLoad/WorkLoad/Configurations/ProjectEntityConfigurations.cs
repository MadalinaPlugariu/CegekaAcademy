using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkLoad.Configurations
{
    public class ProjectEntityConfigurations : IEntityTypeConfiguration <Project> {
        public void Configure(EntityTypeBuilder<Project> builder) {

            builder.Property(p => p.ProjectInfo).IsRequired();
            builder.Property(e => e.EstimationDays).IsRequired();
            builder.Property(c => c.Customer).IsRequired();
            builder.Property(a => a.Address).IsRequired();
            builder.Property(z => z.Zipcode).IsRequired();
            builder.Property(i => i.City).IsRequired();
            builder.Property(s => s.State).IsRequired();
            builder.Property(o => o.County).IsRequired();

        }
    }
    
}

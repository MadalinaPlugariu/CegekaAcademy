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
        }
    }
    
}

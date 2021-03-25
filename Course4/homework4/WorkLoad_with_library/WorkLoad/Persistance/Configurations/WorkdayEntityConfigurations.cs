using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Entities;

namespace Persistance.Configurations
{
    public class WorkdayEntityConfigurations : IEntityTypeConfiguration<Workday>
    {
        public void Configure(EntityTypeBuilder<Workday> builder)
        {
            builder.Property(w => w.Workdays).IsRequired();
            builder.Property(h => h.Hours).IsRequired();
        }
    }
}

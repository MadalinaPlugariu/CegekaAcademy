using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLoad.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkLoad.Configurations
{
    public class WorkdayEntityConfigurations: IEntityTypeConfiguration<Workday>
    {
        public void Configure(EntityTypeBuilder<Workday> builder)
        {
            builder.Property(w=> w.Workdays).IsRequired();
            builder.Property(h => h.Hours).IsRequired();
        }
    }
}

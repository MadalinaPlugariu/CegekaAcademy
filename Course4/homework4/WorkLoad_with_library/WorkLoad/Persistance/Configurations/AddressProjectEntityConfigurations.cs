using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Entities;

namespace Persistance.Configurations
{
    public class AddressProjectEntityConfigurations : IEntityTypeConfiguration<AddressProject>
    {
        public void Configure(EntityTypeBuilder<AddressProject> builder)
        {
            builder.Property(a => a.AddressLocation).IsRequired();
            builder.Property(z => z.Zipcode).IsRequired();
            builder.Property(c => c.City).IsRequired();
            builder.Property(s => s.State).IsRequired();
            builder.Property(x => x.County).IsRequired();
        }
    }
}

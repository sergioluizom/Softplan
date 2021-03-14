using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Softplan.Model.Entities;

namespace Softplan.Infra.EntityConfig
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Area).HasColumnType("decimal(10,2)");
            builder.Property(x => x.Capital);
            builder.Property(x => x.Population).HasColumnType("decimal(10,2)");
        }
    }
}

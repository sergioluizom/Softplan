using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Softplan.Model.Entities;

namespace Softplan.Domain.EntityConfig
{
    public class FlagConfig : IEntityTypeConfiguration<Flag>
    {
        public void Configure(EntityTypeBuilder<Flag> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.SvgFile);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Softplan.Model.Entities;

namespace Softplan.Domain.EntityConfig
{
    public class OfficialLanguageConfig : IEntityTypeConfiguration<OfficialLanguage>
    {
        public void Configure(EntityTypeBuilder<OfficialLanguage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Iso639_1);
            builder.Property(x => x.Iso639_2);
            builder.Property(x => x.Name);
            builder.Property(x => x.NativeName);

            builder.HasOne(x => x.Country).WithMany(x => x.OfficialLanguages).HasForeignKey(x => x.CountryId);
        }
    }
}

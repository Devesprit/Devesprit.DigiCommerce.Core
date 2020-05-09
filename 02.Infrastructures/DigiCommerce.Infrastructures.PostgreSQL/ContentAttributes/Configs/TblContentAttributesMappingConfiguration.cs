using DigiCommerce.Core.Domain.ContentAttributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.ContentAttributes.Configs
{
    public class TblContentAttributesMappingConfiguration : IEntityTypeConfiguration<TblContentAttributesMapping>
    {
        public void Configure(EntityTypeBuilder<TblContentAttributesMapping> builder)
        {
            builder.ToTable("Tbl_ContentAttributesMappingConfiguration");
            builder.Property(p => p.PostAttributeId).IsRequired();
            builder.HasIndex(p => p.PostAttributeId).IsUnique(false);
        }
    }
}

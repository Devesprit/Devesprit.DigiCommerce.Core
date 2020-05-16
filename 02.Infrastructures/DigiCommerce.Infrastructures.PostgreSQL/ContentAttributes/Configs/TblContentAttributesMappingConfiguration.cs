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
            builder.Property(p => p.ContentAttributeId).IsRequired();
            builder.HasIndex(p => p.ContentAttributeId).IsUnique(false);
            builder.HasOne(d => d.AttributeOption)
                .WithMany(p => p.ContentAttributesMappings)
                .HasForeignKey(d => d.AttributeOptionId);

            builder.HasOne(d => d.ContentAttribute)
                .WithMany(p => p.ContentAttributesMappings)
                .HasForeignKey(d => d.ContentAttributeId);
        }
    }
}

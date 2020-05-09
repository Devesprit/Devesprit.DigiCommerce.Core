using DigiCommerce.Core.Domain.ContentAttributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.ContentAttributes.Configs
{
    public class TblContentAttributesConfiguration : IEntityTypeConfiguration<TblContentAttributes>
    {
        public void Configure(EntityTypeBuilder<TblContentAttributes> builder)
        {
            builder.ToTable("Tbl_ContentAttributes");
            builder.Property(p => p.AttributeType).IsRequired();
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
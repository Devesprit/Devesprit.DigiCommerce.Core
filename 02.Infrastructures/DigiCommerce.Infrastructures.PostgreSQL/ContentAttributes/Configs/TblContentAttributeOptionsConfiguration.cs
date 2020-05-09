using DigiCommerce.Core.Domain.ContentAttributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.ContentAttributes.Configs
{
    public class TblContentAttributeOptionsConfiguration : IEntityTypeConfiguration<TblContentAttributeOptions>
    {
        public void Configure(EntityTypeBuilder<TblContentAttributeOptions> builder)
        {
            builder.ToTable("Tbl_ContentAttributeOptions");
            builder.Property(p => p.PostAttributeId).IsRequired();
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
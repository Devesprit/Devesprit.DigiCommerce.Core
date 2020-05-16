using DigiCommerce.Core.Domain.ContentTags;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.ContentTags.Configs
{
    public class TblContentTagsConfiguration : IEntityTypeConfiguration<TblContentTags>
    {
        public void Configure(EntityTypeBuilder<TblContentTags> builder)
        {
            builder.ToTable("Tbl_ContentTags");

            builder.HasIndex(e => e.Tag)
                .HasName("IX_Tag")
                .IsUnique();

            builder.Property(e => e.Tag)
                .IsRequired()
                .HasMaxLength(400)
                .IsUnicode(false);
        }
    }
}

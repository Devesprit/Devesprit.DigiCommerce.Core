using DigiCommerce.Core.Domain.BlogPosts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.BlogPosts.Configs
{
    public class TblBlogPostAttributesMappingConfiguration: IEntityTypeConfiguration<TblBlogPostAttributesMapping>
    {
        public void Configure(EntityTypeBuilder<TblBlogPostAttributesMapping> builder)
        {
            builder.ToTable("Tbl_BlogPostAttributesMapping");

            builder.HasOne(d => d.BlogPost)
                .WithMany(p => p.AttributesMappings)
                .HasForeignKey(d => d.BlogPostId);

            builder.HasOne(d => d.ContentAttributesMapping)
                .WithOne(p => p.BlogPostAttributesMapping)
                .HasForeignKey<TblBlogPostAttributesMapping>(p=>p.ContentAttributesMappingId);
        }
    }
}

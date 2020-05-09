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
        }
    }
}

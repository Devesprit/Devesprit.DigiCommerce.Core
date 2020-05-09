using DigiCommerce.Core.Domain.BlogPosts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.BlogPosts.Configs
{
    public class TblBlogPostDescriptionsConfiguration : IEntityTypeConfiguration<TblBlogPostDescriptions>
    {
        public void Configure(EntityTypeBuilder<TblBlogPostDescriptions> builder)
        {
            builder.ToTable("Tbl_BlogPostDescriptions");
        }
    }
}
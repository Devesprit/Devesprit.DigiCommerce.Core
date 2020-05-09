using DigiCommerce.Core.Domain.BlogPosts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.BlogPosts.Configs
{
    public class TblBlogPostTagsConfiguration : IEntityTypeConfiguration<TblBlogPostTags>
    {
        public void Configure(EntityTypeBuilder<TblBlogPostTags> builder)
        {
            builder.ToTable("Tbl_BlogPostTags");
        }
    }
}
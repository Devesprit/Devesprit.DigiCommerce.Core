using DigiCommerce.Core.Domain.BlogPosts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.BlogPosts.Configs
{
    public class TblBlogPostImagesConfiguration : IEntityTypeConfiguration<TblBlogPostImages>
    {
        public void Configure(EntityTypeBuilder<TblBlogPostImages> builder)
        {
            builder.ToTable("Tbl_BlogPostImages");
        }
    }
}
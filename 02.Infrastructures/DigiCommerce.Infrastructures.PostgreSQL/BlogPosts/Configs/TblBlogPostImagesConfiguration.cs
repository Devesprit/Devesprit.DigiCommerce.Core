using DigiCommerce.Core.Domain.BlogPosts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.BlogPosts.Configs
{
    public class TblBlogPostImagesConfiguration : IEntityTypeConfiguration<TblBlogPostPictures>
    {
        public void Configure(EntityTypeBuilder<TblBlogPostPictures> builder)
        {
            builder.ToTable("Tbl_BlogPostPictures");
        }
    }
}
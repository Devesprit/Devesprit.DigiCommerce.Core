using DigiCommerce.Core.Domain.BlogPosts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.BlogPosts.Configs
{
    public class TblBlogPostCategoriesConfiguration : IEntityTypeConfiguration<TblBlogPostCategories>
    {
        public void Configure(EntityTypeBuilder<TblBlogPostCategories> builder)
        {
            builder.ToTable("Tbl_BlogPostCategories");
        }
    }
}
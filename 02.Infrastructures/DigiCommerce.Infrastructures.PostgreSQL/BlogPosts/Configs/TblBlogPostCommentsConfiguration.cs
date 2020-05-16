using DigiCommerce.Core.Domain.BlogPosts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.BlogPosts.Configs
{
    public class TblBlogPostCommentsConfiguration : IEntityTypeConfiguration<TblBlogPostComments>
    {
        public void Configure(EntityTypeBuilder<TblBlogPostComments> builder)
        {
            builder.ToTable("Tbl_BlogPostComments");

            builder.HasOne(d => d.BlogPost)
                .WithMany(p => p.Comments)
                .HasForeignKey(d => d.BlogPostId);

            builder.HasOne(d => d.Comments)
                .WithOne(p => p.BlogPostComments)
                .HasForeignKey<TblBlogPostComments>(p => p.CommentsId);
        }
    }
}
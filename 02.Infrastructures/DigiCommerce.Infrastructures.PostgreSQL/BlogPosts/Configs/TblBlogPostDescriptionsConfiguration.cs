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

            builder.HasOne(d => d.BlogPost)
                .WithMany(p => p.Descriptions)
                .HasForeignKey(d => d.BlogPostId);

            builder.HasOne(d => d.ContentDescription)
                .WithOne(p => p.BlogPostDescriptions)
                .HasForeignKey<TblBlogPostDescriptions>(p => p.ContentDescriptionId);
        }
    }
}
using DigiCommerce.Core.Domain.BlogPosts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.BlogPosts.Configs
{
    public class TblBlogPostsConfiguration : IEntityTypeConfiguration<TblBlogPosts>
    {
        public void Configure(EntityTypeBuilder<TblBlogPosts> builder)
        {
            builder.ToTable("Tbl_BlogPosts");
            builder.Property(p => p.Title).HasMaxLength(500).IsRequired();
            builder.Property(p => p.PageTitle).HasMaxLength(500);

            builder.Property(p => p.PublishDate).IsRequired();
            builder.HasIndex(p => p.PublishDate).IsUnique(false);

            builder.HasIndex(p => p.Published).IsUnique(false);
            builder.HasIndex(p => p.LastUpDate).IsUnique(false);
            builder.HasIndex(p => p.ShowInHotList).IsUnique(false);
            builder.HasIndex(p => p.NumberOfViews).IsUnique(false);
            builder.HasIndex(p => p.IsFeatured).IsUnique(false);
            builder.HasIndex(p => p.PinToTop).IsUnique(false);
            
            builder.HasIndex(p => p.Slug).IsUnique(false);
            builder.Property(p => p.Slug).HasColumnType("VARCHAR").HasMaxLength(500).IsRequired();

            builder.HasIndex(p => p.AvarageRate).IsUnique(false);
        }
    }
}
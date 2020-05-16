using DigiCommerce.Core.Domain.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Categories.Configs
{
    public class TblCategoriesConfiguration : IEntityTypeConfiguration<TblCategories>
    {
        public void Configure(EntityTypeBuilder<TblCategories> builder)
        {
            builder.ToTable("Tbl_Categories");
            builder.Property(p => p.CategoryName).HasMaxLength(500).IsRequired();
            builder.Property(p => p.Slug)
                .HasMaxLength(500)
                .IsRequired()
                .HasColumnType("VARCHAR");
            builder.HasOne(d => d.ParentCategory)
                .WithMany(p => p.SubCategories)
                .HasForeignKey(d => d.ParentCategoryId);
        }
    }
}

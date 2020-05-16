using DigiCommerce.Core.Domain.Pictures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Pictures.Configs
{
    public class TblPicturesConfiguration : IEntityTypeConfiguration<TblPictures>
    {
        public void Configure(EntityTypeBuilder<TblPictures> builder)
        {
            builder.ToTable("Tbl_Pictures");
            builder.Property(e => e.ImageUrl).IsRequired();
        }
    }
}

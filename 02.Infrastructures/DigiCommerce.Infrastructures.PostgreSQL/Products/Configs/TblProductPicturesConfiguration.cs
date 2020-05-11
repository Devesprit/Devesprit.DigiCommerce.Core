using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
    public class TblProductPicturesConfiguration : IEntityTypeConfiguration<TblProductPictures>
    {
        public void Configure(EntityTypeBuilder<TblProductPictures> builder)
        {

        }
    }
}

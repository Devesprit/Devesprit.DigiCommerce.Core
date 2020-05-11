using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
    public class TblProductsConfiguration : IEntityTypeConfiguration<TblProducts>
    {
        public void Configure(EntityTypeBuilder<TblProducts> builder)
        {
            
        }
    }
}

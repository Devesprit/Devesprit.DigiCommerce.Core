using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
    public class TblProductCheckoutAttributeOptionsConfiguration : IEntityTypeConfiguration<TblProductCheckoutAttributeOptions>
    {
        public void Configure(EntityTypeBuilder<TblProductCheckoutAttributeOptions> builder)
        {
            
        }
    }
}

using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
    public class TblProductAttributesMappingConfiguration : IEntityTypeConfiguration<TblProductAttributesMapping>
    {
        public void Configure(EntityTypeBuilder<TblProductAttributesMapping> builder)
        {
            
        }
    }
}

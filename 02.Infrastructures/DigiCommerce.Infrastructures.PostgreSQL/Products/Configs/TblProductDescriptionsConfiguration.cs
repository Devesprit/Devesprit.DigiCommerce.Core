using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
    public class TblProductDescriptionsConfiguration : IEntityTypeConfiguration<TblProductDescriptions>
    {
        public void Configure(EntityTypeBuilder<TblProductDescriptions> builder)
        {
            
        }
    }
}

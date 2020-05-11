using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
    public class TblProductTagsConfiguration : IEntityTypeConfiguration<TblProductTags>
    {
        public void Configure(EntityTypeBuilder<TblProductTags> builder)
        {
            
        }
    }
}

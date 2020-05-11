using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
    public class TblProductCategoriesConfiguration : IEntityTypeConfiguration<TblProductCategories>
    {
        public void Configure(EntityTypeBuilder<TblProductCategories> builder)
        {
            
        }
    }
}

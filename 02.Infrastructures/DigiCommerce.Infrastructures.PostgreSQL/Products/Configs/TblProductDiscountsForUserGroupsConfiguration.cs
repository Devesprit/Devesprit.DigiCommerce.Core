using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
    public class TblProductDiscountsForUserGroupsConfiguration : IEntityTypeConfiguration<TblProductDiscountsForUserGroups>
    {
        public void Configure(EntityTypeBuilder<TblProductDiscountsForUserGroups> builder)
        {
            
        }
    }
}

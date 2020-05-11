using DigiCommerce.Core.Domain.Users.VipGroups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Users.VipGroups.Configs
{
    public class TblVipGroupsConfiguration : IEntityTypeConfiguration<TblVipGroups>
    {
        public void Configure(EntityTypeBuilder<TblVipGroups> builder)
        {

        }
    }
}

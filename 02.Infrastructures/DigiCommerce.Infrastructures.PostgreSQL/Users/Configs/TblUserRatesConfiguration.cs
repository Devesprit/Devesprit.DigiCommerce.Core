using DigiCommerce.Core.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Users.Configs
{
    public class TblUserRatesConfiguration : IEntityTypeConfiguration<TblUserRates>
    {
        public void Configure(EntityTypeBuilder<TblUserRates> builder)
        {
            
        }
    }
}

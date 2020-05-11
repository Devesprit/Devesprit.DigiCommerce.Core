using DigiCommerce.Core.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Products.Configs
{
   public class TblProductDownloadsLogConfiguration : IEntityTypeConfiguration<TblProductDownloadsLog>
    {
        public void Configure(EntityTypeBuilder<TblProductDownloadsLog> builder)
        {
        }
    }
}

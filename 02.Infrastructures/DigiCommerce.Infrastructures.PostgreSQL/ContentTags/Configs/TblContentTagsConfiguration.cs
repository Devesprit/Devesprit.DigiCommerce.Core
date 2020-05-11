using DigiCommerce.Core.Domain.ContentTags;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.ContentTags.Configs
{
    public class TblContentTagsConfiguration : IEntityTypeConfiguration<TblContentTags>
    {
        public void Configure(EntityTypeBuilder<TblContentTags> builder)
        {
            
        }
    }
}

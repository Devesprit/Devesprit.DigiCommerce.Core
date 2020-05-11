using DigiCommerce.Core.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Users.Configs
{
    public class TblUserBookmarksConfiguration : IEntityTypeConfiguration<TblUserBookmarks>
    {
        public void Configure(EntityTypeBuilder<TblUserBookmarks> builder)
        {

        }
    }
}

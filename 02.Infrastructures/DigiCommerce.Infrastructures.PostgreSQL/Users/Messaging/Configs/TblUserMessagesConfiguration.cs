using DigiCommerce.Core.Domain.Users.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Users.Messaging.Configs
{
    public class TblUserMessagesConfiguration : IEntityTypeConfiguration<TblUserMessages>
    {
        public void Configure(EntityTypeBuilder<TblUserMessages> builder)
        {

        }
    }
}

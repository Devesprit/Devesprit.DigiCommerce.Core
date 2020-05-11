using DigiCommerce.Core.Domain.Users.Notifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Users.Notifications.Configs
{
    public class TblNotificationsConfiguration : IEntityTypeConfiguration<TblNotifications>
    {
        public void Configure(EntityTypeBuilder<TblNotifications> builder)
        {

        }
    }
}

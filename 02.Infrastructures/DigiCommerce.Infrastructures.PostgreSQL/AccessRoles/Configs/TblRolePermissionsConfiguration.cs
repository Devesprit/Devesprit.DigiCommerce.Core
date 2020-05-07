using DigiCommerce.Core.Domain.AccessRoles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.AccessRoles.Configs
{
    public class TblRolePermissionsConfiguration : IEntityTypeConfiguration<TblRolePermissions>
    {
        public void Configure(EntityTypeBuilder<TblRolePermissions> builder)
        {
            builder.ToTable("Tbl_RolePermissions");
            builder.Property(p => p.RoleId).IsRequired();
            builder.Property(p => p.HaveAccess).IsRequired();
            builder.Property(p => p.AreaName).IsRequired();
        }
    }
}
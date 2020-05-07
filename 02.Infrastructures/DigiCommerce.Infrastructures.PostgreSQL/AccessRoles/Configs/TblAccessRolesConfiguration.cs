using DigiCommerce.Core.Domain.AccessRoles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.AccessRoles.Configs
{
    public class TblAccessRolesConfiguration : IEntityTypeConfiguration<TblAccessRoles>
    {
        public void Configure(EntityTypeBuilder<TblAccessRoles> builder)
        {
            builder.ToTable("Tbl_AccessRoles");
            builder.Property(p => p.RoleName).IsRequired();
        }
    }
}

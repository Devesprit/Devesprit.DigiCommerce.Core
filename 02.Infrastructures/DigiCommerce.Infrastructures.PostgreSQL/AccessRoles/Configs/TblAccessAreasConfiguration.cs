using DigiCommerce.Core.Domain.AccessRoles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.AccessRoles.Configs
{
    public class TblAccessAreasConfiguration : IEntityTypeConfiguration<TblAccessAreas>
    {
        public void Configure(EntityTypeBuilder<TblAccessAreas> builder)
        {
            builder.ToTable("Tbl_AccessAreas");
            builder.HasIndex(p => p.AreaName).IsUnique(false);
            var areaName = builder.Property(p => p.AreaName);
            areaName.HasColumnType("VARCHAR");
            areaName.HasMaxLength(500);
            areaName.IsRequired();
            builder.Property(p => p.AreaNameLocalizationResource).IsRequired();
        }
    }
}

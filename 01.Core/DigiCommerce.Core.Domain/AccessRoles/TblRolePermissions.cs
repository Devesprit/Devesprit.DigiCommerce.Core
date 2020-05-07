using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.AccessRoles
{
    [Table("Tbl_RolePermissions")]
    public partial class TblRolePermissions : BaseEntity
    {
        public int RoleId { get; set; }
        public virtual TblAccessRoles Role { get; set; }
        public bool HaveAccess { get; set; }
        public string AreaName { get; set; }
    }
}
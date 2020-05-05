using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace Devesprit.Data.Domain
{
    [Table("Tbl_UserRolePermissions")]
    public partial class TblRolePermissions : BaseEntity
    {
        [Required]
        public int RoleId { get; set; }
        public virtual TblAccessRoles Role { get; set; }
        [Required]
        public bool HaveAccess { get; set; }
        [Required]
        public string AreaName { get; set; }
    }
}
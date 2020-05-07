using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.AccessRoles
{
    [Table("Tbl_AccessRoles")]
    public partial class TblAccessRoles : BaseEntity
    {
        public string RoleName { get; set; }
        public virtual ICollection<TblRolePermissions> Permissions { get; set; }
    }
}

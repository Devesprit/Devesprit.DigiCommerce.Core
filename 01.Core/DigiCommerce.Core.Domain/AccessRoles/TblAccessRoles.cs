using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;
using DigiCommerce.Core.Domain;
using DigiCommerce.Core.Domain.Shared;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Devesprit.Data.Domain
{
    [Table("Tbl_UserRoles")]
    public partial class TblAccessRoles : BaseEntity
    {
        [Required]
        public string RoleName { get; set; }
        public virtual ICollection<TblRolePermissions> Permissions { get; set; }
    }
}

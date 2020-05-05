using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace Devesprit.Data.Domain
{
    [Table("Tbl_FileServers")]
    public partial class TblFileServers : BaseEntity
    {
        [Required, MaxLength(500)]
        public string FileServerName { get; set; }
        [Required, MaxLength(500)]
        public string FileServerUrl { get; set; }
        [Required, MaxLength(500)]
        public string FileUploadServerUrl { get; set; }
        [Required, MaxLength(500)]
        public string ServiceUserName { get; set; }
        [Required, MaxLength(500)]
        public string ServicePassword { get; set; }
    }
}

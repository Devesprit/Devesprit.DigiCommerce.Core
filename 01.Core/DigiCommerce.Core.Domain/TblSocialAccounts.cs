using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace Devesprit.Data.Domain
{
    [Table("Tbl_SocialAccounts")]
    public partial class TblSocialAccounts : BaseEntity
    {
        [Required, MaxLength(250)]
        public string SocialNetworkName { get; set; } 
        [Required]
        public string SocialNetworkIconUrl { get; set; }
        public string SocialNetworkLargeIconUrl { get; set; }
        [Required]
        public string YourAccountUrl { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Shared;
using DigiCommerce.Core.Domain.Users.VipGroups;

namespace DigiCommerce.Core.Domain.Products
{
    [Table("Tbl_ProductCheckoutAttributeOptions")]
    public partial class TblProductCheckoutAttributeOptions : BaseEntity
    {
        [Required]
        //[Index(IsClustered = false, IsUnique = false)]
        public int ProductCheckoutAttributeId { get; set; }
        public virtual TblProductCheckoutAttributes ProductCheckoutAttribute { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        public double RenewalPrice { get; set; }
        public int? PurchaseExpiration { get; set; }
        public TimePeriodType? PurchaseExpirationTimeType { get; set; }
        public string FilesPath { get; set; }
        public int? FileServerId { get; set; }
        public virtual TblFileServers FileServer { get; set; }
        public int? DownloadLimitedToUserGroupId { get; set; }
        public virtual TblVipGroups DownloadLimitedToUserGroup { get; set; }
        public bool HigherUserGroupsCanDownload { get; set; }
        public int DisplayOrder { get; set; }
        public string LicenseGeneratorServiceId { get; set; }
    }
}
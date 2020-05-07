using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Users;
using DigiCommerce.Core.Domain.Users.VipGroups;

namespace DigiCommerce.Core.Domain.Products
{
    [Table("Tbl_Products")]
    public partial class TblProducts
    {
        [Required, MaxLength(500)]
        public string Title { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public bool Published { get; set; }
        [Required]
        //[Index(IsClustered = false, IsUnique = false)]
        public DateTime PublishDate { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public DateTime? LastUpDate { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public bool ShowInHotList { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public int NumberOfViews { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public bool IsFeatured { get; set; }
        public bool ShowSimilarCases { get; set; }
        public bool ShowKeywords { get; set; }
        public bool AllowCustomerReviews { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public bool PinToTop { get; set; }
        [MaxLength(500)]
        public string PageTitle { get; set; }
        [Required,
         StringLength(500),
        // Index(IsClustered = false, IsUnique = true),
        Column(TypeName = "VARCHAR")]
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyWords { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]

        //[Index(IsClustered = false, IsUnique = false)]
        public double Price { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public double RenewalPrice { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public int? PurchaseExpiration { get; set; }
        public TimePeriodType? PurchaseExpirationTimeType { get; set; }
        public string FilesPath { get; set; }
        public string DemoFilesPath { get; set; }
        public bool UserMustLoggedInToDownloadFiles { get; set; }
        public bool AlwaysShowDownloadButton { get; set; }
        public bool UserMustLoggedInToDownloadDemoFiles { get; set; }
        public int? FileServerId { get; set; }
        public virtual TblFileServers FileServer { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public int? DownloadLimitedToUserGroupId { get; set; }
        public virtual TblVipGroups DownloadLimitedToUserGroup { get; set; }
        public bool HigherUserGroupsCanDownload { get; set; }
        public string LicenseGeneratorServiceId { get; set; }

        public virtual ICollection<TblProductImages> Images { get; set; }
        public virtual ICollection<TblProductDescriptions> Descriptions { get; set; }
        public virtual ICollection<BlogPosts.TblProductTags> Tags { get; set; }
        public virtual ICollection<TblProductAttributesMapping> Attributes { get; set; }
        public virtual ICollection<TblProductComments> Comments { get; set; }
        public virtual ICollection<TblProductCategories> Categories { get; set; }
        public virtual ICollection<TblUserRates> UserLikes { get; set; }
        public virtual ICollection<TblUserBookmarks> UserWishlist { get; set; }
        public virtual ICollection<TblProductDownloadsLog> DownloadsLog { get; set; }
        public virtual ICollection<TblProductCheckoutAttributes> CheckoutAttributes { get; set; }
        public virtual ICollection<TblProductDiscountsForUserGroups> DiscountsForUserGroups { get; set; }
    }
}

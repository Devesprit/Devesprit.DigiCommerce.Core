using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.AccessRoles;
using DigiCommerce.Core.Domain.Products;
using DigiCommerce.Core.Domain.Users.VipGroups;

namespace DigiCommerce.Core.Domain.Users
{
    [Table("Tbl_Users")]
    public partial class TblUsers
    {
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public int? UserCountryId { get; set; }
        public virtual TblCountries UserCountry { get; set; }
        public int? UserGroupId { get; set; }
        public virtual TblVipGroups UserGroup { get; set; }
        public int? MaxDownloadCount { get; set; }
        public bool UserDisabled { get; set; }
        public string DisableReason { get; set; }
        public string UserLatestIP { get; set; }
        public DateTime? UserLastLoginDate { get; set; }
        public TimePeriodType? MaxDownloadPeriodType { get; set; }
        public int? RoleId { get; set; }
        public virtual TblAccessRoles Role { get; set; }

        public DateTime? SubscriptionDate { get; set; }
        public DateTime? SubscriptionExpireDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public virtual ICollection<TblInvoices> Invoices { get; set; }
        public virtual ICollection<TblUserRates> Likes { get; set; }
        public virtual ICollection<TblUserBookmarks> Wishlist { get; set; }
        public virtual ICollection<TblProductDownloadsLog> DownloadsLog { get; set; }

    }
}

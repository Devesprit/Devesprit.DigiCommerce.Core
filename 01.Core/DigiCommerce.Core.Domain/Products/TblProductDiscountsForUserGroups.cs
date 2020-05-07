using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Shared;
using DigiCommerce.Core.Domain.Users.VipGroups;

namespace DigiCommerce.Core.Domain.Products
{
    [Table("Tbl_ProductDiscountsForUserGroups")]
    public partial class TblProductDiscountsForUserGroups : BaseEntity
    {
        [Required]
        //[Index(IsClustered = false, IsUnique = false)]
        public int ProductId { get; set; }
        public virtual TblProducts Product { get; set; }
        [Required]
        //[Index(IsClustered = false, IsUnique = false)]
        public int UserGroupId { get; set; }
        public virtual TblVipGroups UserGroup { get; set; }

        [Required]
        public double DiscountPercent { get; set; }
        public bool ApplyDiscountToHigherUserGroups { get; set; }
        public bool ApplyDiscountToProductAttributes { get; set; }
    }
}
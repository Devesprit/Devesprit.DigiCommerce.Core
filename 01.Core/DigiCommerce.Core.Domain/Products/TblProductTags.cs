using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.ContentTags;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.Products
{
    [Table("Tbl_ProductTags")]
    public class TblProductTags : BaseEntity
    {
        public int ProductId { get; set; }
        public virtual TblProducts Product { get; set; }
        public int ContentTagId { get; set; }
        public virtual TblContentTags ContentTag { get; set; }
    }
}

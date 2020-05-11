using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.ContentDescriptions;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.Products
{
    [Table("Tbl_ProductDescriptions")]
    public class TblProductDescriptions : BaseEntity
    {
        public int ProductId { get; set; }
        public virtual TblProducts Product { get; set; }
        public int ContentDescriptionId { get; set; }
        public virtual TblContentDescriptions ContentDescription { get; set; }
    }
}

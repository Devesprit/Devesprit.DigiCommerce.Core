using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.ContentAttributes;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.Products
{
    [Table("Tbl_ProductAttributesMapping")]
    public class TblProductAttributesMapping:BaseEntity
    {
        public int ProductId { get; set; }
        public virtual TblProducts Product { get; set; }
        public int ContentAttributesMappingId { get; set; }
        public virtual TblContentAttributesMapping ContentAttributesMapping { get; set; }
    }
}

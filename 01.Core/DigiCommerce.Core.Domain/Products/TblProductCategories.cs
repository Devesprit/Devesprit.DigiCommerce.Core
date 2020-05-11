using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Categories;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.Products
{
    [Table("Tbl_ProductCategories")]
    public class TblProductCategories:BaseEntity
    {
        public int ProductId { get; set; }
        public virtual TblProducts Product { get; set; }
        public int CategoryId { get; set; }
        public virtual TblCategories Category { get; set; }
    }
}

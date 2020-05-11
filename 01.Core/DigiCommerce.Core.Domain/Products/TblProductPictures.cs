using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Pictures;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.Products
{
    [Table("Tbl_ProductPictures")]
    public class TblProductPictures : BaseEntity
    {
        public int ProductId { get; set; }
        public virtual TblProducts Product { get; set; }
        public int PictureId { get; set; }
        public virtual TblPictures Picture { get; set; }
    }
}

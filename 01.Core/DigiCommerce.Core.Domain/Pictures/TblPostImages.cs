using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.PostImages
{
    [Table(("Tbl_PostImages"))]
    public partial class TblPostImages : BaseEntity
    {
        [Required]
        public string ImageUrl { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
    }
}

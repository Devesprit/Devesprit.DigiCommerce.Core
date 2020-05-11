using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.ContentTags
{
    [Table("Tbl_ContentTags")]
    public partial class TblContentTags : BaseEntity
    {
        [Required,
         StringLength(400),
        // Index(IsUnique = true),
         Column(TypeName = "VARCHAR")]
        public string Tag { get; set; }
        public ContentMainType MainType { get; set; }
    }
}

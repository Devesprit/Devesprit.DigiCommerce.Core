using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.PostTags
{
    [Table("Tbl_PostTags")]
    public partial class TblPostTags : BaseEntity
    {
        [Required,
         StringLength(400),
         Index(IsUnique = true),
         Column(TypeName = "VARCHAR")]
        public string Tag { get; set; }
    }
}

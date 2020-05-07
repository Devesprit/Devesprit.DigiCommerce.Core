using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.ContentDescriptions
{
    [Table("Tbl_PostDescriptions")]
    public partial class TblPostDescriptions: BaseEntity
    {
        [Required, MaxLength(250)]
        public string Title { get; set; }
        [Required]
        public string HtmlDescription { get; set; }
        public int DisplayOrder { get; set; }
        public bool AddToSearchEngineIndexes { get; set; }
        public ContentMainType MainType { get; set; }
    }
}

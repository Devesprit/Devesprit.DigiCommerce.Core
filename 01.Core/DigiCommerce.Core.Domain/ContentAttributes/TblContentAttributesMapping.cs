using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.ContentAttributes
{
    public partial class TblContentAttributesMapping : BaseEntity
    {
        public int PostAttributeId { get; set; }

        public virtual TblContentAttributes PostAttribute { get; set; }

        public int? AttributeOptionId { get; set; }

        public virtual TblContentAttributeOptions AttributeOption { get; set; }

        public string Value { get; set; }

        public int DisplayOrder { get; set; }
        public ContentMainType MainType { get; set; }
    }
}
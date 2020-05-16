using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.ContentAttributes
{
    public partial class TblContentAttributes : BaseEntity
    {
        public ContentAttributeType AttributeType { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TblContentAttributeOptions> Options { get; set; }
        public virtual ICollection<TblContentAttributesMapping> ContentAttributesMappings { get; set; }
    }
}
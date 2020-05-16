using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.ContentAttributes
{
    public partial class TblContentAttributeOptions : BaseEntity
    {
        public int ContentAttributeId { get; set; }
        public string Name { get; set; }
        public virtual TblContentAttributes ContentAttribute { get; set; }
        public virtual ICollection<TblContentAttributesMapping> ContentAttributesMappings { get; set; }
      
    }
}
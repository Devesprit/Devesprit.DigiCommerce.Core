using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.ContentAttributes
{
    public partial class TblContentAttributeOptions : BaseEntity
    {
        public int PostAttributeId { get; set; }
        public virtual TblContentAttributes PostAttribute { get; set; }
        public string Name { get; set; }
    }
}
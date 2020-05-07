using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.ContentAttributes;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    [Table("Tbl_BlogPostAttributesMapping")]
    public class TblBlogPostAttributesMapping:BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostAttributesMappingId { get; set; }
        public virtual TblPostAttributesMapping PostAttributesMapping { get; set; }
    }
}

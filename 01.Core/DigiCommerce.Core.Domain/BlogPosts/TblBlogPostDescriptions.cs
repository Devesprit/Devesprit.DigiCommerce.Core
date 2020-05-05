using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.PostDescriptions;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    [Table("Tbl_BlogPostDescriptions")]
    public class TblDescriptions : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostDescriptionsId { get; set; }
        public virtual TblPostDescriptions PostDescriptions { get; set; }
    }
}

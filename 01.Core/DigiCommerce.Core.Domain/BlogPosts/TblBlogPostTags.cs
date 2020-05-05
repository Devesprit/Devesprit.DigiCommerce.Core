using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.PostTags;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    [Table("Tbl_BlogPostTags")]
    public class TblProductTags : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostTagId { get; set; }
        public virtual TblPostTags PostTag { get; set; }
    }
}

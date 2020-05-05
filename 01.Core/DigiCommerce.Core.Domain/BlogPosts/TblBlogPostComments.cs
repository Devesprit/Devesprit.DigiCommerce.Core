using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.PostComments;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    [Table("Tbl_BlogPostComments")]
    public class TblProductComments : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostCommentsId { get; set; }
        public virtual TblPostComments PostComments{ get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Comments;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    public class TblBlogPostComments : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int CommentsId { get; set; }
        public virtual TblComments Comments { get; set; }
    }
}

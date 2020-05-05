using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.PostImages;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    [Table("Tbl_BlogPostImages")]
    public class TblBlogPostImages : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostImagesId { get; set; }
        public virtual TblPostImages PostImages { get; set; }
    }
}

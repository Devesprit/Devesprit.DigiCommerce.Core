using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Pictures;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    public class TblBlogPostImages : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostImagesId { get; set; }
        public virtual TblPostImages PostImages { get; set; }
    }
}

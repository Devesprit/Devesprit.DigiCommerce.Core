using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Pictures;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    public class TblBlogPostPictures : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PictureId { get; set; }
        public virtual TblPictures Picture { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.BlogPosts;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.Pictures
{
    public partial class TblPictures : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
        public virtual TblBlogPostPictures BlogPostPictures { get; set; }
    }
}

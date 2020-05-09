using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.ContentDescriptions;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    public class TblBlogPostDescriptions : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostDescriptionsId { get; set; }
        public virtual TblPostDescriptions PostDescriptions { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.ContentTags;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    public class TblBlogPostTags : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostTagId { get; set; }
        public virtual TblContentTags PostTag { get; set; }
    }
}

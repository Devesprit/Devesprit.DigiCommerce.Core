using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.BlogPosts;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.ContentTags
{
    public partial class TblContentTags : BaseEntity
    {
        public string Tag { get; set; }
        public ContentMainType MainType { get; set; }
        public virtual ICollection<TblBlogPostTags> BlogPostTags { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.BlogPosts;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.ContentDescriptions
{
    public partial class TblContentDescriptions: BaseEntity
    {
        public string Title { get; set; }
        public string HtmlDescription { get; set; }
        public int DisplayOrder { get; set; }
        public bool AddToSearchEngineIndexes { get; set; }
        public ContentMainType MainType { get; set; }
        public virtual TblBlogPostDescriptions BlogPostDescriptions { get; set; }
    }
}

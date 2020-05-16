using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.BlogPosts;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.Categories
{
    public partial class TblCategories: BaseEntity
    {
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public bool ShowInFooter { get; set; }
        public int DisplayOrder { get; set; }
        public int? ParentCategoryId { get; set; }
        public DisplayArea DisplayArea { get; set; }
        public ContentMainType MainType { get; set; }
        public virtual TblCategories ParentCategory { get; set; }
        public virtual ICollection<TblCategories> SubCategories { get; set; }
        public virtual ICollection<TblBlogPostCategories> BlogPostCategories { get; set; }
    }
}

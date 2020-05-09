using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Categories;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    public class TblBlogPostCategories : BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostCategoriesId { get; set; }
        public virtual TblCategories PostCategories { get; set; }
    }
}

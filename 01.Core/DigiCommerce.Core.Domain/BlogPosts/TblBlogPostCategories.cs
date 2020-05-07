using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Categories;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    [Table("Tbl_BlogPostDescriptions")]
    public class TblProductCategories:BaseEntity
    {
        public int BlogPostId { get; set; }
        public virtual TblBlogPosts BlogPost { get; set; }
        public int PostCategoriesId { get; set; }
        public virtual TblPostCategories PostCategories { get; set; }
    }
}

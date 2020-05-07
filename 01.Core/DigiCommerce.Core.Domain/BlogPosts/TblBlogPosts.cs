using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    [Table("Tbl_BlogPosts")]
    public class TblBlogPosts : BaseEntity
    {
        [Required, MaxLength(500)]
        public string Title { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public bool Published { get; set; }
        [Required]
        //[Index(IsClustered = false, IsUnique = false)]
        public DateTime PublishDate { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public DateTime? LastUpDate { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public bool ShowInHotList { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public int NumberOfViews { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public bool IsFeatured { get; set; }
        public bool ShowSimilarCases { get; set; }
        public bool ShowKeywords { get; set; }
        public bool AllowCustomerReviews { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public bool PinToTop { get; set; }
        [MaxLength(500)]
        public string PageTitle { get; set; }
        [Required,
         StringLength(500),
         //Index(IsClustered = false, IsUnique = true),
        Column(TypeName = "VARCHAR")]
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyWords { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public int AvarageRate { get; set; }

        public virtual ICollection<TblBlogPostImages> Images { get; set; }
        public virtual ICollection<TblDescriptions> Descriptions { get; set; }
        public virtual ICollection<TblBlogPostAttributesMapping> AttributesMappings { get; set; }
        public virtual ICollection<TblProductTags> Tags { get; set; }
        public virtual ICollection<TblProductComments> Comments { get; set; }
        public virtual ICollection<TblProductCategories> Categories { get; set; }
    }
}

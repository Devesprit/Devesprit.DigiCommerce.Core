using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.BlogPosts
{
    public class TblBlogPosts : BaseEntity
    {
        public string Title { get; set; }
        public bool Published { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime? LastUpDate { get; set; }
        public bool ShowInHotList { get; set; }
        public int NumberOfViews { get; set; }
        public bool IsFeatured { get; set; }
        public bool ShowSimilarCases { get; set; }
        public bool ShowKeywords { get; set; }
        public bool AllowCustomerReviews { get; set; }
        public bool PinToTop { get; set; }
        public string PageTitle { get; set; }
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyWords { get; set; }
        public int AvarageRate { get; set; }

        public virtual ICollection<TblBlogPostImages> Images { get; set; }
        public virtual ICollection<TblBlogPostDescriptions> Descriptions { get; set; }
        public virtual ICollection<TblBlogPostAttributesMapping> AttributesMappings { get; set; }
        public virtual ICollection<TblBlogPostTags> Tags { get; set; }
        public virtual ICollection<TblBlogPostComments> Comments { get; set; }
        public virtual ICollection<TblBlogPostCategories> Categories { get; set; }
    }
}

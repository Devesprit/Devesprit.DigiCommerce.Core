﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.PostCategories
{
    [Table("Tbl_PostCategories")]
    public partial class TblPostCategories: BaseEntity
    {
        [Required, MaxLength(500)]
        public string CategoryName { get; set; }
        [Required,
         StringLength(500),
         Index(IsUnique = true),
        Column(TypeName = "VARCHAR")]
        public string Slug { get; set; }
        public bool ShowInFooter { get; set; }
        public int DisplayOrder { get; set; }
        public int? ParentCategoryId { get; set; }
        public DisplayArea DisplayArea { get; set; }
        public ContentMainType MainType { get; set; }
        public virtual TblPostCategories ParentCategory { get; set; }
        public virtual ICollection<TblPostCategories> SubCategories { get; set; }
    }
}

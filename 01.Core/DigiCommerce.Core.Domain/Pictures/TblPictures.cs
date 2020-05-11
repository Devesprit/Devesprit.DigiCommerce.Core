﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.Pictures
{
    [Table(("Tbl_PostImages"))]
    public partial class TblPictures : BaseEntity
    {
        [Required]
        public string ImageUrl { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
        public int DisplayOrder { get; set; }
    }
}
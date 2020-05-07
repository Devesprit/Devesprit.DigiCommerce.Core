﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.ContentAttributes
{
    [Table("Tbl_PostAttributes")]
    public partial class TblPostAttributes : BaseEntity
    {
        [Required]
        public PostAttributeType AttributeType { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<TblPostAttributeOptions> Options { get; set; }
    }
}
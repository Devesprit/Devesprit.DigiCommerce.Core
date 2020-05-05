﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace Devesprit.Data.Domain
{
    [Table("Tbl_PostAttributeOptions")]
    public partial class TblPostAttributeOptions : BaseEntity
    {
        [Required]
        public int PostAttributeId { get; set; }
        public virtual TblPostAttributes PostAttribute { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
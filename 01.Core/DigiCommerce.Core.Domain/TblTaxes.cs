﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace Devesprit.Data.Domain
{
    [Table("Tbl_Taxes")]
    public partial class TblTaxes : BaseEntity
    {
        [Required, MaxLength(250)]
        public string TaxName { get; set; }
        public double Amount { get; set; }
        public bool IsActive { get; set; }
    }
}

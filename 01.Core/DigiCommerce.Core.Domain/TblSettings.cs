﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace Devesprit.Data.Domain
{
    [Table("Tbl_Settings")]
    public partial class TblSettings : BaseEntity
    {
        public TblSettings() { }

        public TblSettings(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(450)]
        //[Index(IsClustered = false, IsUnique = false)]
        public string Name { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

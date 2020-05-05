﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain;
using DigiCommerce.Core.Domain.Shared;

namespace Devesprit.Data.Domain
{
    [Table("Tbl_UserAccessAreas")]
    public partial class TblAccessAreas : BaseEntity
    {
        public TblAccessAreas()
        {}

        public TblAccessAreas(string parentAreaName, string areaName, string areaNameLocalizationResource)
        {
            ParentAreaName = parentAreaName;
            AreaName = areaName;
            AreaNameLocalizationResource = areaNameLocalizationResource;
        }
         
        public string ParentAreaName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(500)]
        [Index(IsClustered = false, IsUnique = false)]
        public string AreaName { get; set; }

        [Required]
        public string AreaNameLocalizationResource { get; set; }
    }
}
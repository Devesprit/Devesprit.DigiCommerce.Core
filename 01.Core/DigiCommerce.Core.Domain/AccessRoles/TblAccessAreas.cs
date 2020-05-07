using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.AccessRoles
{
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

        public string AreaName { get; set; }

        public string AreaNameLocalizationResource { get; set; }
    }
}
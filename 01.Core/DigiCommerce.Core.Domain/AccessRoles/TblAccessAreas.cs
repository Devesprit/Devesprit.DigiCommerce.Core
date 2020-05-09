using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.AccessRoles
{
    public partial class TblAccessAreas : BaseEntity
    {
        public string ParentAreaName { get; set; }

        public string AreaName { get; set; }

        public string AreaNameLocalizationResource { get; set; }
    }
}
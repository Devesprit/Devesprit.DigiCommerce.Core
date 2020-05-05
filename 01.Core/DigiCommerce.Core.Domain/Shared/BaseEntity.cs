using System.ComponentModel.DataAnnotations;

namespace DigiCommerce.Core.Domain.Shared
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        [Key]
        public int Id { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigiCommerce.Core.Domain.Shared;

namespace DigiCommerce.Core.Domain.Users
{
    [Table("Tbl_UserBookmarks")]
    public partial class TblUserBookmarks : BaseEntity
    {
        public DateTime Date { get; set; }
        [Required]
        //[Index(IsClustered = false, IsUnique = false)]
        public int PostId { get; set; }
        //public virtual TblPosts Post { get; set; }
        //public PostType? PostType { get; set; }
        [Required]
        //[Index(IsClustered = false, IsUnique = false)]
        public string UserId { get; set; }
        public virtual TblUsers User { get; set; }
    }
}
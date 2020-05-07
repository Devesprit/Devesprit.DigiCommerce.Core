using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Devesprit.Data.Domain;
using DigiCommerce.Core.Domain.Shared;
using DigiCommerce.Core.Domain.Users;

namespace DigiCommerce.Core.Domain.Comments
{
    [Table("Tbl_PostComments")]
    public partial class TblPostComments : BaseEntity
    {
        [Required]
        public string Comment { get; set; }
        public string Quote { get; set; }
        [Required]
        public DateTime CommentDate { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public int? ParentCommentId { get; set; }
        public virtual TblPostComments ParentComment { get; set; }
        //[Index(IsClustered = false, IsUnique = false)]
        public string UserId { get; set; }
        public virtual TblUsers User { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool Published { get; set; }
        public bool NotifyWhenReply { get; set; }
        public bool NotifyWhenNewComment { get; set; }
        public ContentMainType MainType { get; set; }
    }
}

using DigiCommerce.Core.Domain.Comments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiCommerce.Infrastructures.PostgreSQL.Comments.Configs
{
    public class TblCommentsConfiguration : IEntityTypeConfiguration<TblComments>
    {
        public void Configure(EntityTypeBuilder<TblComments> builder)
        {
            builder.ToTable("Tbl_Comments");
            builder.Property(p => p.Comment).IsRequired();
            builder.Property(p => p.CommentDate).IsRequired();
            builder.HasIndex(p => p.ParentCommentId).IsUnique(false);
            builder.HasIndex(p => p.UserId).IsUnique(false);
        }
    }
}

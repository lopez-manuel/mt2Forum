using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasData(
            new Comment
            {
                Id = 1,
                Content = "This is a comment",
                PostId = 1
            },
            new Comment
            {
                Id = 3,
                Content = "This is another comment for post 1",
                PostId = 1
            },
            new Comment
            {
                Id = 2,
                Content = "This is a comment for post 2",
                PostId = 2
            });
    }
}
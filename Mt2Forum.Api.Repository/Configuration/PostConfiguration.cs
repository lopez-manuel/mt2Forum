using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasData(
            new Post()
            {
                Id = 1,
                CategoryId = 1,
                Content = "New post",
                Created = DateTime.Now,
                Title = "New Post",
            },
            new Post()
            {
                Id = 2,
                CategoryId = 1,
                Content = "<h1>New Post</h1>",
                Created = DateTime.Now,
                Title = "Hello World!",
            });

        builder.HasMany<Comment>(e => e.Comment)
            .WithOne(e => e.Post)
            .HasForeignKey(e => e.PostId)
            .HasPrincipalKey(e => e.Id);
    }
}
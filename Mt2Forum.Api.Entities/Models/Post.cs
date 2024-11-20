using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Post
{
    [Column("PostId")]
    public int Id { get; set; }
    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; } = null!;
    [Required(ErrorMessage = "Content is required")]
    public string Content { get; set; } = null!;
    [Required(ErrorMessage = "Created time is required")]
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    [Required(ErrorMessage = "Category is required")]
    public int CategoryId { get; set; }
    public ICollection<Comment>? Comment { get; set; } = null!;
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Comment
{
    [Column("CommentId")]
    public int Id { get; set; }

    [Required(ErrorMessage = "{0} is required")]
    [MaxLength(120, ErrorMessage = "{0} cannot be longer than 120 characters.")]
    public string Content { get; set; } = null!;
    public int PostId { get; set; }
    
    public Post? Post { get; set; } = null!;
}
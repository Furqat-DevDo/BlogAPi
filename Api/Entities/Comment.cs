global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Entities;

public class Comment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid Id { get; set; } = Guid.NewGuid(); 
    [Required]
    [MaxLength(1024)]
    public string Content { get; set; }

    [ForeignKey("Posts")]
    public Guid PostId { get; set; }

    [Required]
    public DateTimeOffset CreatedAt { get; set; }
    
    [Required]
    public DateTimeOffset ModifiedAt { get; set; }

    public Comment(string content, Guid postId)
    {
        Content = content;
        PostId = postId;

        CreatedAt = DateTimeOffset.UtcNow;
        ModifiedAt = DateTimeOffset.UtcNow;
    } 
}

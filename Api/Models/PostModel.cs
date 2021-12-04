namespace Api.Models;
public class PostModel
{
  [Required]
  [MaxLength(255)]
  public string Title { get; set; }
    
  [MaxLength(1024)]
  public string Description { get; set; }
    
  [Required]
  public string Content { get; set; }
  public Guid? HeaderImageId { get; set; }
    
  [Required]
  public IEnumerable<Guid> MediaIds { get; set; }
      
}
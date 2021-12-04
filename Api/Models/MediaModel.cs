namespace Api.Models;
public class MediaModel
{

  [MaxLength(255)]
  public string AltText { get; set; }
  public IFormFile File { get; set; }

}

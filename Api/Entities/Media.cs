namespace Api.Entities;

public class Media
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid Id { get; set; } = Guid.NewGuid(); 
    public string AltText { get; set; }
    
    public byte[] Data { get; set; }
    
    public string ContentType { get; set; }

    public Guid? PostId { get; set; }
    public Post Post { get; set; }
    
    
    public Media(string altText, byte[] data, string contentType)
    {
        AltText = altText;
        Data = data;
        ContentType = contentType;
    }
}

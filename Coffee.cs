namespace Starbaucks.Domain;

public class Coffee : BaseEntety
{
    public required string Name { get; set; }
    
    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public string? Imagen { get; set; }

}
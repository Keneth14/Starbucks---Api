namespace Starbaucks.Domain;

public class Category
{
    public int Id { get; set; }

    public required String Name { get; set; }

    public string? Description { get; set; }
}
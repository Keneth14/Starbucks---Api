namespace Starbaucks.Domain;

public class BaseEntety
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
}

namespace DatabaseTesting.Models;

public abstract class FileDetailBase
{
    public Guid Id { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    
    public DateTimeOffset UpdatedAt { get; set; }
    
    public required string UpdatedBy { get; set; }
}

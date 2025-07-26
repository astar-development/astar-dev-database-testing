namespace AStar.Dev.Infrastructure.FilesDb.Models;

/// <summary>
/// </summary>
public class Event
{
    /// <summary>
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// </summary>
    public EventType Type { get; set; } = EventType.Update;

    /// <summary>
    /// </summary>
    public DateTimeOffset EventOccurredAt { get; set; }

    /// <summary>
    /// </summary>
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string DirectoryName { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public string Handle { get; set; } = string.Empty;

    /// <summary>
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// </summary>
    public long FileSize { get; set; }

    /// <summary>
    /// </summary>
    public DateTimeOffset FileCreated { get; set; }

    /// <summary>
    /// </summary>
    public DateTimeOffset FileLastModified { get; set; }

    /// <summary>
    ///     Gets or sets the Updated By property to track who made the change
    /// </summary>
    public string UpdatedBy { get; set; } = "Jay Barden";
}

namespace AStar.Dev.Infrastructure.FilesDb.Models;

/// <summary>
/// </summary>
/// <param name="Value"></param>
public readonly record struct FileName(string Value)
{
    /// <summary>
    /// </summary>
    /// <returns></returns>
    public override string ToString() => Value;
}

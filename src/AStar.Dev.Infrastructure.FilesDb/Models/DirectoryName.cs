using Microsoft.EntityFrameworkCore;

namespace AStar.Dev.Infrastructure.FilesDb.Models;

/// <summary>
/// </summary>
/// <param name="Value"></param>
[Index(nameof(Value))]
public record DirectoryName(string Value);

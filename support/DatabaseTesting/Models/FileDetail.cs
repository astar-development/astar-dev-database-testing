namespace DatabaseTesting.Models;

public class FileDetail : FileDetailBase
{
    public required string FileName { get; set; }

    public long FileSize { get; set; }

    public required string FileType { get; set; }

    public required string DirectoryPath { get; set; }

    public bool IsImage { get; set; } = true;

    public ImageDetail ImageDetail { get; set; } = new(null, null);
}

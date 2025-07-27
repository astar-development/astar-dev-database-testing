using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

public class FileHandleShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new FileHandle { Value = "mock-file-handle" }
           .ToJson()
           .ShouldMatchApproved();

    [Fact]
    public void DefineTheImplicitConversion()
    {
        var fileHandle = new FileHandle("mock-file-handle");

        string sut = fileHandle;

        sut.ShouldBe("mock-file-handle");
    }
}

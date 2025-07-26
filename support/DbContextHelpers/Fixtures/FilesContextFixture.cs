using AStar.Dev.Infrastructure.FilesDb.Data;

namespace DbContextHelpers.Fixtures;

/// <summary>
/// </summary>
public class FilesContextFixture : IDisposable
{
    private bool disposedValue;

    public FilesContext Sut { get; } = MockFilesContextFactory.CreateMockFilesContextAsync().Result;

    public FilesContext SutWithFileDetails
    {
        get
        {
            TestContext = MockFilesContextFactory.CreateMockFilesContextAsync().Result;
            TestContext.AddMockFiles();

            return TestContext;
        }
    }

    public required FilesContext TestContext { get; set; }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if(disposedValue)
        {
            return;
        }

        if(disposing)
        {
            try
            {
                TestContext.Database.EnsureDeleted();
            }
            catch
            {
                // NAR
            }

            Sut.Dispose();
        }

        disposedValue = true;
    }
}

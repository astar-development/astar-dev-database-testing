using DbContextHelpers.Fixtures;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DbContextHelpers;

public static class TestSetup
{
    static TestSetup()
    {
        var serviceCollection = new ServiceCollection();

        var configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile(
                                         path: "appsettings.json",
                                         optional: true,
                                         reloadOnChange: true)
                            .AddUserSecrets<FilesContextFixture>()
                            .Build();

        serviceCollection.AddSingleton<IConfiguration>(configuration);

        ServiceProvider = serviceCollection.BuildServiceProvider();
    }

    public static ServiceProvider ServiceProvider { get; private set; }
}

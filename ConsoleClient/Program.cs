using DavidTielke.PMA.CrossCutting.Configuration.Contract;
using DavidTielke.PMA.Infrastructure.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient;

internal class Program
{
    static void Main(string[] args)
    {
        var collection = new ServiceCollection();
        collection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();
        new ServiceCollectionInitializer().Initialize(collection);

        var provider = collection.BuildServiceProvider();

        var config = provider.GetRequiredService<IConfigurator>();
        config.Set("AgeThreshold", 10);
        config.Set("CsvPath", "data.csv");

        var commands = provider.GetRequiredService<IPersonDisplayCommands>();

        commands.DisplayAllAdults();

        commands.DisplayAllChildren();
    }
}
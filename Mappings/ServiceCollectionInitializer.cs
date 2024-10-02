using DavidTielke.PMA.CrossCutting.Configuration;
using DavidTielke.PMA.CrossCutting.Configuration.Contract;
using DavidTielke.PMA.Data.DataStorage;
using DavidTielke.PMA.Data.DataStorage.Contract;
using DavidTielke.PMA.Data.FileStorage;
using DavidTielke.PMA.Data.FileStorage.Contract;
using DavidTielke.PMA.Logic.Business.Workflows.Contract;
using DavidTielke.PMA.Logic.Business.Workflows.PersonManagement;
using DavidTielke.PMA.Logic.Domain.PersonManagement;
using DavidTielke.PMA.Logic.Domain.PersonManagement.Contract;
using DavidTielke.PMA.Logic.Integration.EmailManagement;
using DavidTielke.PMA.Logic.Integration.EmailManagement.Contract;
using DavidTielke.PMA.Logic.Integration.OutlookManagement;
using DavidTielke.PMA.Logic.Integration.OutlookManagement.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.Infrastructure.Mappings;

public class ServiceCollectionInitializer
{
    public void Initialize(IServiceCollection services)
    {
        services.AddTransient<IPersonAddWorkflow, PersonAddWorkflow>();
        services.AddTransient<IPersonManager, PersonManager>();
        services.AddTransient<IPersonRepository, PersonRepository>();
        services.AddTransient<IFileReader, FileReader>();
        services.AddTransient<IPersonParser, PersonParser>();
        services.AddTransient<IEmailSender, EmailSender>();
        services.AddTransient<IOutlookContactManager, OutlookContactManager>();
        services.AddSingleton<IConfigurator, Configurator>();
    }
}
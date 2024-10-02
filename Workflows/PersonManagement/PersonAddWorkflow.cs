using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Logic.Business.Workflows.Contract;
using DavidTielke.PMA.Logic.Domain.PersonManagement.Contract;
using DavidTielke.PMA.Logic.Integration.EmailManagement.Contract;
using DavidTielke.PMA.Logic.Integration.OutlookManagement.Contract;

namespace DavidTielke.PMA.Logic.Business.Workflows.PersonManagement;

public class PersonAddWorkflow : IPersonAddWorkflow
{
    private readonly IPersonManager _personManager;
    private readonly IEmailSender _mailSender;
    private readonly IOutlookContactManager _outlookContactManager;

    public PersonAddWorkflow(IPersonManager personManager, IEmailSender mailSender, IOutlookContactManager outlookContactManager)
    {
        _personManager = personManager;
        _mailSender = mailSender;
        _outlookContactManager = outlookContactManager;
    }

    public void Run(Person person)
    {
        _personManager.Add(person);

        _outlookContactManager.Add();

        _mailSender.Send("Sie wurden hinzugefügt");
    }
}
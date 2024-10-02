using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Logic.Business.Workflows.Contract;
using DavidTielke.PMA.Logic.Domain.PersonManagement.Contract;

namespace DavidTielke.PMA.UI.ConsoleClient;

public class PersonDisplayCommands : IPersonDisplayCommands
{
    private IPersonManager _personManager;
    private readonly IPersonAddWorkflow _personAddWorkflow;

    public PersonDisplayCommands(IPersonManager personManager, IPersonAddWorkflow personAddWorkflow)
    {
        _personManager = personManager;
        _personAddWorkflow = personAddWorkflow;
    }

    public void DisplayAllAdults()
    {
        var adults = _personManager.GetAllAdults().ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));
    }

    public void AddNewPerson()
    {
        var newPerson = new Person
        {
            Id = 6,
            Name = "Idefix",
            Age = 1
        };

        _personAddWorkflow.Run(newPerson);
    }

    public void DisplayAllChildren()
    {
        var children = _personManager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(a => Console.WriteLine(a.Name));
    }
}
using DavidTielke.PMA.CrossCutting.Configuration.Contract;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStorage.Contract;
using DavidTielke.PMA.Logic.Domain.PersonManagement.Contract;

namespace DavidTielke.PMA.Logic.Domain.PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _repository;
    private readonly int AGE_THRESHOLD;
    private readonly string AGE_THRESHOLD_KEY = "AgeThreshold";

    public PersonManager(IPersonRepository repository,
        IConfigurator config)
    {
        _repository = repository;
        AGE_THRESHOLD = config.Get<int>(AGE_THRESHOLD_KEY);
    }

    public void Add(Person person)
    {
        _repository.Insert(person);
    }

    public IQueryable<Person> GetAllAdults()
    {
        var adults = _repository
            .Query()
            .Where(p => p.Age >= AGE_THRESHOLD);
        return adults;
    }

    public IQueryable<Person> GetAllChildren()
    {
        var children = _repository
            .Query()
            .Where(p => p.Age < AGE_THRESHOLD);
        return children;
    }
}
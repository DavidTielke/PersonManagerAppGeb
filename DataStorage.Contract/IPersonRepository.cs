using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStorage.Contract;

public interface IPersonRepository
{
    IQueryable<Person> Query();
    void Insert(Person person);
}
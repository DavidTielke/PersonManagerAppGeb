using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Logic.Domain.PersonManagement.Contract;

public interface IPersonManager
{
    void Add(Person person);
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}
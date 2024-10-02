using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStorage.Contract;

namespace DavidTielke.PMA.Data.DataStorage;

public class PersonParser : IPersonParser
{
    public Person ParseFromCsv(string dataLine)
    {
        var parts = dataLine.Split(",");
        var person = new Person
        {
            Id = int.Parse(parts[0]),
            Name = parts[1],
            Age = int.Parse(parts[2]),
        };
        return person;
    }
}
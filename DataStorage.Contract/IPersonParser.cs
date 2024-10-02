using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStorage.Contract;

public interface IPersonParser
{
    Person ParseFromCsv(string dataLine);
}
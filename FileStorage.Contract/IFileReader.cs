namespace DavidTielke.PMA.Data.FileStorage.Contract;

public interface IFileReader
{
    IEnumerable<string> ReadAllLines(string path);
}
using DavidTielke.PMA.Data.FileStorage.Contract;

namespace DavidTielke.PMA.Data.FileStorage;

public class FileReader : IFileReader
{
    public IEnumerable<string> ReadAllLines(string path)
    {
        var lines = File.ReadAllLines(path);
        return lines;
    }
}
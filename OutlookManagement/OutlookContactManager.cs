using DavidTielke.PMA.Logic.Integration.OutlookManagement.Contract;

namespace DavidTielke.PMA.Logic.Integration.OutlookManagement;

public class OutlookContactManager : IOutlookContactManager
{
    public void Add()
    {
        Console.WriteLine("Kontakt zu Outlook hinzugefügt");
    }

}
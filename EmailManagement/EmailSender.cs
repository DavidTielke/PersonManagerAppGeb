using DavidTielke.PMA.Logic.Integration.EmailManagement.Contract;

namespace DavidTielke.PMA.Logic.Integration.EmailManagement;

public class EmailSender : IEmailSender
{
    public void Send(string text)
    {
        Console.WriteLine($"Email send {text}");
    }
}
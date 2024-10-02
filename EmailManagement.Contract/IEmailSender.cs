namespace DavidTielke.PMA.Logic.Integration.EmailManagement.Contract;

public interface IEmailSender
{
    void Send(string text);
}
namespace DavidTielke.PMA.CrossCutting.Configuration.Contract;

public interface IConfigurator
{
    T Get<T>(string key);
    void Set(string key, object value);
}

public interface ProductImageFactory
{
    public byte[] GetProductImage(string type)
    {

    }
}

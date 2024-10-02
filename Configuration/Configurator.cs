using DavidTielke.PMA.CrossCutting.Configuration.Contract;

namespace DavidTielke.PMA.CrossCutting.Configuration
{
    public class Configurator : IConfigurator
    {
        private readonly Dictionary<string, object> _items;

        public Configurator()
        {
            _items = new Dictionary<string, object>();
        }

        public void Initialize()
        {

        }

        public T Get<T>(string key)
        {
            return (T)_items[key];
        }

        public void Set(string key, object value)
        {
            _items[key] = value;
        }
    }
}

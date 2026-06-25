using Service.Contract;

namespace Service;

public class ServiceManager: IServiceManager
{
    private readonly Lazy<ICurrenciesService> _currencies;
    
    public ServiceManager()
    {
        _currencies =  new Lazy<ICurrenciesService>(() => new CurrenciesService());
    }
    
    public ICurrenciesService Currencies => _currencies.Value;
}
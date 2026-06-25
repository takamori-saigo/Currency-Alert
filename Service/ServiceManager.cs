using AutoMapper;
using Contract;
using Repository;
using Service.Contract;

namespace Service;

public class ServiceManager: IServiceManager
{
    private readonly Lazy<ICurrenciesService> _currencies;
    
    public ServiceManager(IManagerRepository repositoryManager, IMapper mapper)
    {
        _currencies =  new Lazy<ICurrenciesService>(() => new CurrenciesService(repositoryManager, mapper));
    }
    
    public ICurrenciesService Currencies => _currencies.Value;
}
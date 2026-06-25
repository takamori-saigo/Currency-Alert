using Contract;

namespace Repository;

public class RepositoryManager: IManagerRepository
{
    private readonly Lazy<ICurrenciesRepository> _currencies;
    
    public RepositoryManager(CurrencyAlertContext context)
    {
        _currencies =  new Lazy<ICurrenciesRepository>(() => new CurrenciesRepository(context));
    }
    
    public ICurrenciesRepository Currencies => _currencies.Value;
}
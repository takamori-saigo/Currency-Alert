using Contract;

namespace Repository;

public class ManagerRepository: IManagerRepository
{
    private readonly Lazy<ICurrenciesRepository> _currencies;
    
    public ManagerRepository(CurrencyAlertContext context)
    {
        _currencies =  new Lazy<ICurrenciesRepository>(() => new CurrenciesRepository(context));
    }
    
    public ICurrenciesRepository Currencies => _currencies.Value;
}
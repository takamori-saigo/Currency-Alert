using Contract;
using Domain.Models;

namespace Repository;

public class CurrenciesRepository: RepositoryBase<Currency>, ICurrenciesRepository
{
    public CurrenciesRepository(CurrencyAlertContext context) : base(context)
    {
    }
}
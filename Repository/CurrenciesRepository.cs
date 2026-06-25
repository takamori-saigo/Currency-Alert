using Contract;
using Domain.Models;

namespace Repository;

public class CurrenciesRepository: RepositoryBase<Currencies>, ICurrenciesRepository
{
    public CurrenciesRepository(CurrencyAlertContext context) : base(context)
    {
    }
}
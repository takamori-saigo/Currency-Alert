using Contract;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Shared;

namespace Repository;

public class CurrenciesRepository: RepositoryBase<Currency>, ICurrenciesRepository
{
    public CurrenciesRepository(CurrencyAlertContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Currency>> GetAllCurrencies(bool trackChanges)
    {
        return await FindAll(trackChanges).ToListAsync();
    }
}
using Domain.Models;

namespace Contract;

public interface ICurrenciesRepository
{
    Task<IEnumerable<Currency>> GetAllCurrencies(bool trackChanges);
}
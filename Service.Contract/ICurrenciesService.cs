using Shared;

namespace Service.Contract;

public interface ICurrenciesService
{
    Task<IEnumerable<CurrencyDto>> GetAllCurrencies();
}
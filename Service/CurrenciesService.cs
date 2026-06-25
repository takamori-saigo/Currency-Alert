using AutoMapper;
using Repository;
using Service.Contract;
using Shared;

namespace Service;

public class CurrenciesService: ICurrenciesService
{
    private readonly RepositoryManager  _repositoryManager;
    private readonly IMapper _mapper;
    public CurrenciesService(RepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper =  mapper;
    }
    
    public async Task<IEnumerable<CurrencyDto>> GetAllCurrencies()
    {
        var currencies =  await _repositoryManager.Currencies.GetAllCurrencies(false);
        var currenciesDto = _mapper.Map<IEnumerable<CurrencyDto>>(currencies);
        return currenciesDto;
    }
}
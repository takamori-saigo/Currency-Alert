namespace Contract;

public interface IManagerRepository
{
    ICurrenciesRepository Currencies { get; }
}
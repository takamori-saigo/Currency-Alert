namespace Service.Contract;

public interface IServiceManager
{
    ICurrenciesService Currencies { get; }
}
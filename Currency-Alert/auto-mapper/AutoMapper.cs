using AutoMapper;
using Domain.Models;
using Shared;
using IConfigurationProvider = AutoMapper.IConfigurationProvider;

namespace Currency_Alert.auto_mapper;

public class AutoMapper: Profile
{
    public AutoMapper()
    {
        CreateMap<CurrencyDto, Currency>();
    }
}
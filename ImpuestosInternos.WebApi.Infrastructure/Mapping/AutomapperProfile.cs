using AutoMapper;
using ImpuestosInternos.WebApi.Core.Dtos;
using ImpuestosInternos.WebApi.Core.Entities;

namespace ImpuestosInternos.WebApi.Infrastructure.Mapping;

public class AutomapperProfile: Profile
{
    public AutomapperProfile()
    {
        CreateMap<Contributor, ContributorDto>();
        CreateMap<FiscalReceipt, FiscalReceipDto>().ReverseMap();
        CreateMap<TypeContributor, TypeContributorDto>().ReverseMap();
    }
}
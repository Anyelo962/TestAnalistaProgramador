using ImpuestosInternos.WebApi.Core.Entities;
using ImpuestosInternos.WebApi.Core.Interfaces;
using ImpuestosInternos.WebApi.Infrastructure.InternalRevenueDb;

namespace ImpuestosInternos.WebApi.Infrastructure.Repository;

public class TypeContributorRepository: BaseRepository<TypeContributor>, ITypeContributorRepository
{
    public TypeContributorRepository(InternalRevenueDbContex context) : base(context)
    {
    }
}
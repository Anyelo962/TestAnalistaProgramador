using ImpuestosInternos.WebApi.Core.Entities;
using ImpuestosInternos.WebApi.Core.Interfaces;
using ImpuestosInternos.WebApi.Infrastructure.InternalRevenueDb;
using Microsoft.EntityFrameworkCore;

namespace ImpuestosInternos.WebApi.Infrastructure.Repository;

public class ContributorRepository: BaseRepository<Contributor>, IContributorRepository
{
    public ContributorRepository(InternalRevenueDbContex context) : base(context)
    {
    }
    
}
using ImpuestosInternos.WebApi.Core.Entities;
using ImpuestosInternos.WebApi.Core.Interfaces;
using ImpuestosInternos.WebApi.Infrastructure.InternalRevenueDb;
using Microsoft.EntityFrameworkCore;

namespace ImpuestosInternos.WebApi.Infrastructure.Repository;

public class FiscalReceipRepository: BaseRepository<FiscalReceipt>, IFiscalReceiptRepository
{
    private readonly InternalRevenueDbContex _contex;
    public FiscalReceipRepository(InternalRevenueDbContex context) : base(context)
    {
        this._contex = context;
    }


    public async Task<IEnumerable<FiscalReceipt>> GetFiscalReceipByContributor(int id) 
        => await _contex.FiscalReceipts.Where(x => x.ContributorId == id).ToListAsync();
}
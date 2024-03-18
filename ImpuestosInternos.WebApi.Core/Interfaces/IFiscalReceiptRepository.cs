using ImpuestosInternos.WebApi.Core.Entities;

namespace ImpuestosInternos.WebApi.Core.Interfaces;

public interface IFiscalReceiptRepository: IBaseRepository<FiscalReceipt>
{
    Task<IEnumerable<FiscalReceipt>> GetFiscalReceipByContributor(int id);
}
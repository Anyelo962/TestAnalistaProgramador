using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImpuestosInternos.WebApi.Core.Entities;

[Table(name:"ComprobantesFiscales")]
public class FiscalReceipt: BaseEntity
{
    [DisplayName("RncCedula")]
    public string RncDocument { get; set; }
    [DisplayName("NCF")]
    public string Ncf { get; set; }
    [DisplayName("Monto")]
    public double Amount { get; set; }
    [DisplayName("Itbis18")]
    public double Itbist { get; set; }
    [DisplayName("ContribuyenteId")]
    public int ContributorId { get; set; }
    public Contributor Contributor { get; set; }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImpuestosInternos.WebApi.Core.Entities;
[Table(name:"Contribuyente")]
public class Contributor : BaseEntity
{
    [DisplayName("rncCedula")]
    public string rncDocument { get; set; }
    [DisplayName("Nombre")]
    public string name { get; set; }
    [DisplayName("Tipo")]
    public TypeContributor TypeContributor { get; set; }
    public int TypeId { get; set; }
    [DisplayName("Estatus")]
    public bool IsActive { get; set; }
    
    public ICollection<FiscalReceipt> FiscalReceiptsCollection { get; set; }
    
}
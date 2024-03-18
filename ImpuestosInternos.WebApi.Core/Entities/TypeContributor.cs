using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImpuestosInternos.WebApi.Core.Entities;

[Table("TipoContribuidor")]
public class TypeContributor: BaseEntity
{
    [DisplayName("Tipos")]
    public string type { get; set; }
    public ICollection<Contributor> Contributors { get; set; }
}
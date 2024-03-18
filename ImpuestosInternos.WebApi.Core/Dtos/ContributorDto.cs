namespace ImpuestosInternos.WebApi.Core.Dtos;

public class ContributorDto
{
    public string rncDocument { get; set; }
    public string name { get; set; } 
    public int TypeId { get; set; }
    public bool IsActive { get; set; }
}
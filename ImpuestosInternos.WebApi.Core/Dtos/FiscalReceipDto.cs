namespace ImpuestosInternos.WebApi.Core.Dtos;

public class FiscalReceipDto
{
    public string RncDocument { get; set; }
    public string Ncf { get; set; }
    public double Amount { get; set; }
    public double Itbist { get; set; }
}
using ImpuestosInternos.WebApi.Core.Entities;
using ImpuestosInternos.WebApi.Infrastructure.InternalRevenueDb;

namespace ImpuestosInternos.WebApi.Infrastructure.Data;

public class ManualDataForTest
{
    
    public List<Contributor> Contributors { get; set; }
    public List<FiscalReceipt> FiscalReceipts { get; set; }
    public List<TypeContributor> ContributorsType { get; set; }

    private readonly InternalRevenueDbContex _contex;
    
    public ManualDataForTest(InternalRevenueDbContex contex)
    {
        _contex = contex;
    }

    public async Task AddNew()
    {
        await _contex.TypeContributors.AddRangeAsync(ContributorsType);
        await _contex.SaveChangesAsync();
        
        Contributors = new List<Contributor>()
        {
            new Contributor()
            {
                rncDocument = "98754321012",
                name = "JUAN PEREZ",
                TypeId = 2,
                IsActive = true
            },
            new Contributor()
            {
                rncDocument = "83848292839",
                name = "MARIA FERMÍN",
                TypeId = 2,
                IsActive = true
            },
            new Contributor()
            {
                rncDocument = "84958594843",
                name = "JOSE FERNÁNDEZ",
                TypeId = 1,
                IsActive = true
            },
            new Contributor()
            {
                rncDocument = "84938283742",
                name = "FARMACIA TU SALUD",
                TypeId = 2,
                IsActive = true
            },
            new Contributor()
            {
                rncDocument = "73948483244",
                name = "CENTRO MEDICO CABRAL",
                TypeId = 2,
                IsActive = true
            },
            new Contributor()
            {
                rncDocument = "40593928452",
                name = "FARMACIA GIRASOLES",
                TypeId = 2,
                IsActive = false
            },
            new Contributor()
            {
                rncDocument = "29384758583",
                name = "JOSEFA MARTINEZ",
                TypeId = 1,
                IsActive = true
            },
            new Contributor()
            {
                rncDocument = "93848383747",
                name = "MELODY GONZALES",
                TypeId = 1,
                IsActive = true
            },
            new Contributor()
            {
                rncDocument = "9485837385",
                name = "COMPUTER TEST COMPANY",
                TypeId = 2,
                IsActive = true
            }
        };
        
        await _contex.Contributors.AddRangeAsync(Contributors);
        await _contex.SaveChangesAsync();
        
        FiscalReceipts =  new List<FiscalReceipt>()
         {
        new FiscalReceipt()
        {
            RncDocument = "98754321012",
            Ncf = "E310000000041",
            Amount = 800.00,
            Itbist = 144.00
        },
        new FiscalReceipt()
        {
            RncDocument = "98754321012",
            Ncf = "E310000000041",
            Amount = 500.00,
            Itbist = 90.00
        },
        new FiscalReceipt()
        {
            RncDocument = "98754321012",
            Ncf = "E310000000041",
            Amount = 1500.00,
            Itbist = 270.00
        },
        new FiscalReceipt()
        {
            RncDocument = "83848292839",
            Ncf = "E310000000140",
            Amount = 500.00,
            Itbist = 36.00
        },
        new FiscalReceipt()
        {
            RncDocument = "83848292839",
            Ncf = "E310000000140",
            Amount = 2500.00,
            Itbist = 450.00
        },
        new FiscalReceipt()
        {
            RncDocument = "83848292839",
            Ncf = "E310000000140",
            Amount = 300.00,
            Itbist = 54.00
        },
        new FiscalReceipt()
        {
            RncDocument = "83848292839",
            Ncf = "E310000000140",
            Amount = 450.00,
            Itbist = 81.00
        },
        new FiscalReceipt()
        {
            RncDocument = "84958594843",
            Ncf = "E310000000948",
            Amount = 650.00,
            Itbist = 117.00
        },
        new FiscalReceipt()
        {
            RncDocument = "84958594843",
            Ncf = "E310000000948",
            Amount = 850.00,
            Itbist = 153.00
        },
        new FiscalReceipt()
        {
            RncDocument = "84938283742",
            Ncf = "E310000000637",
            Amount = 900.00,
            Itbist = 162.00
        },
        new FiscalReceipt()
        {
            RncDocument = "84938283742",
            Ncf = "E310000000637",
            Amount = 999.00,
            Itbist = 179.82
        },
        new FiscalReceipt()
        {
            RncDocument = "84938283742",
            Ncf = "E310000000637",
            Amount = 2300.00,
            Itbist = 414.00
        },
        new FiscalReceipt()
        {
            RncDocument = "73948483244",
            Ncf = "E310000000746",
            Amount = 3500.00,
            Itbist = 630.00
        },
        new FiscalReceipt()
        {
            RncDocument = "73948483244",
            Ncf = "E310000000746",
            Amount = 1800.00,
            Itbist = 324.00
        },
        new FiscalReceipt()
        {
            RncDocument = "40593928452",
            Ncf = "E310000000832",
            Amount = 1950.00,
            Itbist = 351.00
        },
        new FiscalReceipt()
        {
            RncDocument = "40593928452",
            Ncf = "E310000000832",
            Amount = 4500.00,
            Itbist = 810.00
        },
        new FiscalReceipt()
        {
            RncDocument = "40593928452",
            Ncf = "E310000000832",
            Amount = 3760.00,
            Itbist = 676.80
        },
        new FiscalReceipt()
        {
            RncDocument = "29384758583",
            Ncf = "E310000007463",
            Amount = 5990.00,
            Itbist = 1078.20
        },
        new FiscalReceipt()
        {
            RncDocument = "29384758583",
            Ncf = "E310000007463",
            Amount = 4800.00,
            Itbist = 864.00
        },
        new FiscalReceipt()
        {
            RncDocument = "93848383747",
            Ncf = "E310000008495",
            Amount = 2320.00,
            Itbist = 417.60
        },
        new FiscalReceipt()
        {
            RncDocument = "93848383747",
            Ncf = "E310000008495",
            Amount = 6540.00,
            Itbist = 1177.20
        },
        new FiscalReceipt()
        {
            RncDocument = "93848383747",
            Ncf = "E310000008495",
            Amount = 1500.00,
            Itbist = 270.00
        },
        new FiscalReceipt()
        {
            RncDocument = "9485837385",
            Ncf = "E310000008577",
            Amount = 500.00,
            Itbist = 36.00
        },
        new FiscalReceipt()
        {
            RncDocument = "9485837385",
            Ncf = "E310000008577",
            Amount = 500.00,
            Itbist = 36.00
        },
        new FiscalReceipt()
        {
            RncDocument = "9485837385",
            Ncf = "E310000008577",
            Amount = 500.00,
            Itbist = 36.00
        },
        new FiscalReceipt()
        {
            RncDocument = "9485837385",
            Ncf = "E310000008577",
            Amount = 500.00,
            Itbist = 36.00
        }
    };


        await _contex.FiscalReceipts.AddRangeAsync(FiscalReceipts);
        await _contex.SaveChangesAsync();

    }
    
}
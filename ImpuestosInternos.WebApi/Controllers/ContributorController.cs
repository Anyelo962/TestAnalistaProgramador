using AutoMapper;
using ImpuestosInternos.WebApi.Core.Dtos;
using ImpuestosInternos.WebApi.Core.Entities;
using ImpuestosInternos.WebApi.Core.Interfaces;
using ImpuestosInternos.WebApi.Infrastructure.Data;
using ImpuestosInternos.WebApi.Infrastructure.InternalRevenueDb;
using Microsoft.AspNetCore.Mvc;

namespace ImpuestosInternos.WebApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ContributorController : ControllerBase
{

    private readonly IContributorRepository _contributorRepository;
    private readonly ITypeContributorRepository _typeContributorRepository;
    private readonly IFiscalReceiptRepository _fiscalReceiptRepository;
    private readonly IMapper _mapper;

    public ContributorController(IContributorRepository contributorRepository, ITypeContributorRepository typeContributorRepository, IFiscalReceiptRepository fiscalReceiptRepository, IMapper mapper)
    {
        _contributorRepository = contributorRepository;
        _typeContributorRepository = typeContributorRepository;
        _fiscalReceiptRepository = fiscalReceiptRepository;
        _mapper = mapper;

        //AddManualData().Wait();
    }


    [HttpGet("paginated", Name = "GetContributorPagined")]
    public async Task<ActionResult<ApiResponse>> GetContributorPagined(int pageIndex = 1, int pageSize = 10)
    {
        var contributos = await _contributorRepository.PaginateList(pageIndex, pageSize);
        var contributorsList = _mapper.Map<IEnumerable<ContributorDto>>(contributos);
    
        return new ApiResponse(true, Response.StatusCode.ToString(), contributorsList);
        
    }
    
    [HttpGet("all", Name = "GetallContrubutor")]
    public async Task<ActionResult<ApiResponse>> GetAllContributor()
    {
        var getList = await _contributorRepository.GetAll();
    
        var contributorDto = _mapper.Map<IEnumerable<ContributorDto>>(getList);
        
        return new ApiResponse(true, Response.StatusCode.ToString(), contributorDto );
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse>> GetFiscalReceipByContributor(int id)
    {

        var getFiscalReceipByContributor = await _fiscalReceiptRepository.GetFiscalReceipByContributor(id);

        
        var mapper = _mapper.Map<IEnumerable<FiscalReceipDto>>(getFiscalReceipByContributor);

        return new ApiResponse(true,Response.StatusCode.ToString(),mapper);
    }
    
    private async Task AddManualData()
    {

        var result = await _typeContributorRepository.GetAll();
        if (result.ToList().Count() <= 0)
        {
            List<TypeContributor>  ContributorsType = new List<TypeContributor>()
            {
                new TypeContributor()
                {
                    type = "PERSONA FISICA"
                },
                new TypeContributor()
                {
                    type = "PERSONA JURIDICA"
                }
            };

           await _typeContributorRepository.AddRange(ContributorsType);

           List<Contributor> Contributors = new List<Contributor>()
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
                },
                new Contributor()
                {
                    rncDocument = "9485837385",
                    name = "COMPUTER GAME COMPANY",
                    TypeId = 2,
                    IsActive = true
                }
            };

            await _contributorRepository.AddRange(Contributors);
            
            List<FiscalReceipt> FiscalReceipts =  new List<FiscalReceipt>()
             {
            new FiscalReceipt()
            {
                RncDocument = "98754321012",
                Ncf = "E310000000041",
                ContributorId = 1,
                Amount = 800.00,
                Itbist = 144.00
            },
            new FiscalReceipt()
            {
                RncDocument = "98754321012",
                Ncf = "E310000000041",
                ContributorId = 1,
                Amount = 500.00,
                Itbist = 90.00
            },
            new FiscalReceipt()
            {
                RncDocument = "98754321012",
                Ncf = "E310000000041",
                ContributorId = 1,
                Amount = 1500.00,
                Itbist = 270.00
            },
            new FiscalReceipt()
            {
                RncDocument = "83848292839",
                Ncf = "E310000000140",
                ContributorId = 2,
                Amount = 500.00,
                Itbist = 36.00
            },
            new FiscalReceipt()
            {
                RncDocument = "83848292839",
                Ncf = "E310000000140",
                ContributorId = 2,
                Amount = 2500.00,
                Itbist = 450.00
            },
            new FiscalReceipt()
            {
                RncDocument = "83848292839",
                Ncf = "E310000000140",
                ContributorId = 2,
                Amount = 300.00,
                Itbist = 54.00
            },
            new FiscalReceipt()
            {
                RncDocument = "83848292839",
                Ncf = "E310000000140",
                ContributorId = 2,
                Amount = 450.00,
                Itbist = 81.00
            },
            new FiscalReceipt()
            {
                RncDocument = "84958594843",
                Ncf = "E310000000948",
                ContributorId = 3,
                Amount = 650.00,
                Itbist = 117.00
            },
            new FiscalReceipt()
            {
                RncDocument = "84958594843",
                Ncf = "E310000000948",
                ContributorId = 3,
                Amount = 850.00,
                Itbist = 153.00
            },
            new FiscalReceipt()
            {
                RncDocument = "84938283742",
                Ncf = "E310000000637",
                ContributorId = 4,
                Amount = 900.00,
                Itbist = 162.00
            },
            new FiscalReceipt()
            {
                RncDocument = "84938283742",
                Ncf = "E310000000637",
                ContributorId = 4,
                Amount = 999.00,
                Itbist = 179.82
            },
            new FiscalReceipt()
            {
                RncDocument = "84938283742",
                Ncf = "E310000000637",
                ContributorId = 4,
                Amount = 2300.00,
                Itbist = 414.00
            },
            new FiscalReceipt()
            {
                RncDocument = "73948483244",
                Ncf = "E310000000746",
                ContributorId = 5,
                Amount = 3500.00,
                Itbist = 630.00
            },
            new FiscalReceipt()
            {
                RncDocument = "73948483244",
                Ncf = "E310000000746",
                ContributorId = 5,
                Amount = 1800.00,
                Itbist = 324.00
            },
            new FiscalReceipt()
            {
                RncDocument = "40593928452",
                Ncf = "E310000000832",
                ContributorId = 6,
                Amount = 1950.00,
                Itbist = 351.00
            },
            new FiscalReceipt()
            {
                RncDocument = "40593928452",
                Ncf = "E310000000832",
                ContributorId = 6,
                Amount = 4500.00,
                Itbist = 810.00
            },
            new FiscalReceipt()
            {
                RncDocument = "40593928452",
                Ncf = "E310000000832",
                ContributorId = 6,
                Amount = 3760.00,
                Itbist = 676.80
            },
            new FiscalReceipt()
            {
                RncDocument = "29384758583",
                Ncf = "E310000007463",
                ContributorId = 7,
                Amount = 5990.00,
                Itbist = 1078.20
            },
            new FiscalReceipt()
            {
                RncDocument = "29384758583",
                Ncf = "E310000007463",
                ContributorId = 7,
                Amount = 4800.00,
                Itbist = 864.00
            },
            new FiscalReceipt()
            {
                RncDocument = "93848383747",
                Ncf = "E310000008495",
                ContributorId = 8,
                Amount = 2320.00,
                Itbist = 417.60
            },
            new FiscalReceipt()
            {
                RncDocument = "93848383747",
                Ncf = "E310000008495",
                ContributorId = 8,
                Amount = 6540.00,
                Itbist = 1177.20
            },
            new FiscalReceipt()
            {
                RncDocument = "93848383747",
                Ncf = "E310000008495",
                ContributorId = 8,
                Amount = 1500.00,
                Itbist = 270.00
            },
            new FiscalReceipt()
            {
                RncDocument = "9485837385",
                Ncf = "E310000008577",
                ContributorId = 9,
                Amount = 500.00,
                Itbist = 36.00
            },
            new FiscalReceipt()
            {
                RncDocument = "9485837385",
                Ncf = "E310000008577",
                ContributorId = 10,
                Amount = 500.00,
                Itbist = 36.00
            },
            new FiscalReceipt()
            {
                RncDocument = "9485837385",
                Ncf = "E310000008577",
                ContributorId = 10,
                Amount = 500.00,
                Itbist = 36.00
            },
            new FiscalReceipt()
            {
                RncDocument = "9485837385",
                Ncf = "E310000008577",
                ContributorId = 10,
                Amount = 500.00,
                Itbist = 36.00
            }
        };
            
           await _fiscalReceiptRepository.AddRange(FiscalReceipts);
        }

    }
}
using AutoMapper;
using Umbler.Application.Dtos.Responses;
using Umbler.Domain.Entities.Response;

namespace Umbler.Application.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<CieloTransactionResponse, CieloTransactionResponseDto>().ReverseMap();
        }
    }
}

using AutoMapper;
using Contas.Domain.Models;
using Contas.Domain.RequestModels;
using Contas.Domain.ResponseModels;

namespace Contas.Application.API.Configurations.Mapping
{
    public class ContaPagarProfile : Profile
    {
        public ContaPagarProfile()
        {
            CreateMap<ContaPagar, ContaPagarRequest>().ReverseMap();
            CreateMap<ContaPagar, ContaPagarResponse>().ReverseMap();
        }
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Author;
using VirtualBookstore.Application.DTOs.ViaCepApi;
using VirtualBookstore.Domain.DTOs.Adress;
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Application.AutoMapper.AddressProfile
{
    public sealed class GetAdressByCepMapProfile : Profile
    {
        public GetAdressByCepMapProfile()
        {
            CreateMap<ViaCepResponse, GetAdressByCepResponse>()
            .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(src => src.Cep))
            .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Logradouro))
            .ForMember(dest => dest.Complement, opt => opt.MapFrom(src => src.Complemento))
            .ForMember(dest => dest.Neighborhood, opt => opt.MapFrom(src => src.Bairro))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Localidade))
            .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.Uf));
        }
    }
}

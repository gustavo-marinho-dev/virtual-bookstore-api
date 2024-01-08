using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Author;
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Application.AutoMapper.AuthorProfile
{
    public sealed class CreateAuthorMapProfile : Profile
    {
        public CreateAuthorMapProfile()
        {
            CreateMap<CreateAuthorRequest, Author>();

            CreateMap<Author, AuthorResponse>()
                .ForMember(dest => dest.Books, opt => opt.MapFrom(src => new List<Guid>()));
        }
    }
}

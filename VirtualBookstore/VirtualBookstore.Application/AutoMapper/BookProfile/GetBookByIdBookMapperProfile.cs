using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Book;
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Application.AutoMapper.BookProfile
{
    public sealed class GetBookByIdBookMapperProfile : Profile
    {
        public GetBookByIdBookMapperProfile()
        {
            CreateMap<Book, GetBookByIdBookResponse>()
                .ForMember(dest => dest.AuthorList, opt => opt.MapFrom(so => so.Authors.Select(a => a.FullName).ToList()));
        }
    }
}

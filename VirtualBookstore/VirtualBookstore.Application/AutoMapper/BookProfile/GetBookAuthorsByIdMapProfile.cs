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
    public class GetBookAuthorsByIdMapProfile : Profile
    {
        public GetBookAuthorsByIdMapProfile()
        {
            CreateMap<Book, GetBookAuthorsByIdResponse>()
                .ForMember(dest => dest.BookId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.AuthorList, opt => opt.MapFrom(src => src.Authors));

            CreateMap<Author, AuthorList>()
                .ForMember(dest => dest.AuthorId, opt => opt.MapFrom(src => src.Id));
        }
    }
}

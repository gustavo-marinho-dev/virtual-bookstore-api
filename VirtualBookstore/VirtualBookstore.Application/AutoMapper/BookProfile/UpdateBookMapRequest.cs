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
    public sealed class UpdateBookMapProfile : Profile
    {
        public UpdateBookMapProfile()
        {
            CreateMap<Book, Book>();

            CreateMap<UpdateBookRequest, Book>()
                .ForMember(dest => dest.Authors, opt => opt.Ignore());

            CreateMap<Book, BookResponse>()
                .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject.ToString()))
                .ForMember(dest => dest.Backing, opt => opt.MapFrom(src => src.Backing.ToString()));
        }
    }
}

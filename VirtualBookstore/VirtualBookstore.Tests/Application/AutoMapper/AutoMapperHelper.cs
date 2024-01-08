using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.AutoMapper.BookProfile;

namespace VirtualBookstore.UnitTests.Application.AutoMapper
{
    public static class AutoMapperHelper
    {
        public static IMapper Initialize()
        {
            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CreateBookMapProfile>();
            });

            return configuration.CreateMapper();
        }
    }
}

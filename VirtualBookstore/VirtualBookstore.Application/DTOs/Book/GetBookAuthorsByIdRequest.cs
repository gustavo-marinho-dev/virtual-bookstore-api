using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBookstore.Application.DTOs.Book
{
    public sealed record GetBookAuthorsByIdRequest(Guid Id) : IRequest<GetBookAuthorsByIdResponse>;
}

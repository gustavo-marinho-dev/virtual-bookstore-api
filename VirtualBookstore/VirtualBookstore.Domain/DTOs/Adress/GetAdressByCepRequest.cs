using MediatR;
using VirtualBookstore.Application.DTOs.ViaCepApi;

namespace VirtualBookstore.Domain.DTOs.Adress
{
    public sealed record GetAdressByCepRequest(string Cep) : IRequest<GetAdressByCepResponse>;
}

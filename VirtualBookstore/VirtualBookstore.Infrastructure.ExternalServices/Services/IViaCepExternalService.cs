using Refit;
using VirtualBookstore.Application.DTOs.ViaCepApi;

namespace VirtualBookstore.Infrastructure.ExternalServices.Services
{
    public interface IViaCEPExternalService
    {
        [Get("/{cep}/json/")]
        Task<ViaCepResponse> BuscaCep(string cep);
    }
}

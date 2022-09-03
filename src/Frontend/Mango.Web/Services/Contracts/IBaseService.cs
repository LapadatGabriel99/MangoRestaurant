using Mango.Web.Dto;

namespace Mango.Web.Services.Contracts
{
    public interface IBaseService : IDisposable
    {
        ResponseDto ResponseModel { get; set; }

        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}

using Mango.Web.Dto;
using Mango.Web.Services.Contracts;

namespace Mango.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(IHttpClientFactory httpClient) : base(httpClient)
        {

        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = ApiRequestType.POST,
                Data = productDto,
                Url = ApiDetails.ProductApiBase + "/api/products",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = ApiRequestType.DELETE,
                Data = id,
                Url = ApiDetails.ProductApiBase + "/api/products/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = ApiRequestType.GET,
                Url = ApiDetails.ProductApiBase + "/api/products",
                AccessToken = ""
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int id)
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = ApiRequestType.GET,
                Url = ApiDetails.ProductApiBase + "/api/products/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
        {
            return await SendAsync<T>(new ApiRequest
            {
                ApiType = ApiRequestType.PUT,
                Data = productDto,
                Url = ApiDetails.ProductApiBase + "/api/products",
                AccessToken = ""
            });
        }
    }
}
